using MockQueryable;
using Moq;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data;
using NoteLy.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Services.Tests
{
    [TestFixture]
    public class HomeServiceTests
    {
        private Mock<IRepository<Song, int>> songRepository;
        private Mock<IRepository<PlayList, int>> playlistRepository;
        private Mock<IRepository<Artist, int>> artistRepository;
        private Mock<IRepository<Comment, int>> commentRepository;
        private Mock<IRepository<ArtistSong, object>> artistSongRepository;
        private Mock<IRepository<ApplicationUser, Guid>> userRepository;

        [SetUp]
        public void SetUp()
        {
            this.songRepository = new Mock<IRepository<Song, int>>();
            this.playlistRepository = new Mock<IRepository<PlayList, int>>();
            this.artistRepository = new Mock<IRepository<Artist, int>>();
            this.commentRepository = new Mock<IRepository<Comment, int>>();
            this.artistSongRepository = new Mock<IRepository<ArtistSong, object>>();
            this.userRepository = new Mock<IRepository<ApplicationUser, Guid>>();
        }

        [Test]
        public async Task GetAllPlaylistsWithSongsAndArtistsReturnsSongsWhenPlaylistExists()
        {
            int playlistId = 1;
            var currentUserId = Guid.NewGuid();

            IList<PlayList> playlistsList = new List<PlayList>
            {
                new PlayList()
                {
                    Id = playlistId,
                    ApplicationUserId = Guid.NewGuid(),
                    Songs = new List<Song>
                    {
                        new Song
                        {
                            Id = 1,
                            Name = "Song 1",
                            Duration = TimeSpan.FromMinutes(3),
                            ApplicationUserId = currentUserId,
                            Artists = new List<ArtistSong>
                            {
                                new ArtistSong { Artist = new Artist { UserName = "Artist 1" } },
                                new ArtistSong { Artist = new Artist { UserName = "Artist 2" } }
                            }
                        }
                    }
                }
            };

            var playlistsListMock = playlistsList.BuildMock();

            this.playlistRepository.Setup(repo => repo.GetAllAttached())
                .Returns(playlistsListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);

            var result = await homeService.GetAllPlaylistsWithSongsAndArtists(playlistId, currentUserId);

            Assert.IsNotNull(result);
            var playlistsWithSongsAndArtists = result.ToList();
            Assert.That(playlistsWithSongsAndArtists.Count, Is.EqualTo(1));
            Assert.That(playlistsWithSongsAndArtists[0].Name, Is.EqualTo("Song 1"));
            Assert.That(playlistsWithSongsAndArtists[0].Artists.Length, Is.EqualTo(2));
            Assert.That(playlistsWithSongsAndArtists[0].Artists[0], Is.EqualTo("Artist 1"));
            Assert.That(playlistsWithSongsAndArtists[0].Artists[1], Is.EqualTo("Artist 2"));
            Assert.That(playlistsWithSongsAndArtists[0].IsCreator, Is.True);
        }

        [Test]
        public async Task GetAllPlaylistsWithSongsAndArtistsReturnsEmptyWhenPlaylistHasNoSongs()
        {
            int playlistId = 1;
            var currentUserId = Guid.NewGuid();

            IList<PlayList> playlistsList = new List<PlayList>
            {
                new PlayList
                {
                    Id = playlistId,
                    ApplicationUserId = Guid.NewGuid(),
                    Songs = new List<Song>()
                }
            };

            var playlistsListMock = playlistsList.BuildMock();

            this.playlistRepository.Setup(repo => repo.GetAllAttached())
                .Returns(playlistsListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);

            var result = await homeService.GetAllPlaylistsWithSongsAndArtists(playlistId, currentUserId);

            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllPlaylistsWithSongsAndArtistsReturnsNullWhenPlaylistDoesNotExist()
        {
            int playlistId = 1;
            var currentUserId = Guid.NewGuid();

            IList<PlayList> emptyPlaylistsList = new List<PlayList> {};

            var emptyPlaylistsListMock = emptyPlaylistsList.BuildMock();

            this.playlistRepository.Setup(repo => repo.GetAllAttached())
                .Returns(emptyPlaylistsListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);

            var result = await homeService.GetAllPlaylistsWithSongsAndArtists(playlistId, currentUserId);

            Assert.IsNull(result);
        }

        [Test]
        public async Task GetCommentsBySongIdReturnsCommentsWhenCommentsExist()
        {
            int songId = 1;
            var currentUserId = Guid.NewGuid();
            var otherUserId = Guid.NewGuid();

            IList<Comment> commentsList = new List<Comment>
            {
                new Comment { Id = 1, Text = "Great song!", SongId = songId, ApplicationUserId = currentUserId },
                new Comment { Id = 2, Text = "Love it!", SongId = songId, ApplicationUserId = otherUserId }
            };

            IList<ApplicationUser> usersList = new List<ApplicationUser>
            {
                new ApplicationUser { Id = currentUserId, UserName = "CurrentUser" },
                new ApplicationUser { Id = otherUserId, UserName = "OtherUser" }
            };

            var commentsListMock = commentsList.BuildMock();
            var usersListMock = usersList.BuildMock();

            this.commentRepository.Setup(repo => repo.GetAllAttached())
                .Returns(commentsListMock);
            this.userRepository.Setup(repo => repo.GetAllAttached())
                .Returns(usersListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);

            var result = await homeService.GetCommentsBySongId(songId, currentUserId);

            Assert.IsNotNull(result);
            var commentList = result.ToList();
            Assert.That(commentList.Count, Is.EqualTo(2));

            Assert.That(commentList[0].Text, Is.EqualTo("Great song!"));
            Assert.That(commentList[0].ApplicationUserName, Is.EqualTo("CurrentUser"));
            Assert.IsTrue(commentList[0].IsCreator);

            Assert.That(commentList[1].Text, Is.EqualTo("Love it!"));
            Assert.That(commentList[1].ApplicationUserName, Is.EqualTo("OtherUser"));
            Assert.IsFalse(commentList[1].IsCreator);
        }

        [Test]
        public async Task GetCommentsBySongIdReturnsEmptyWhenNoCommentsExistForSong()
        {
            int songId = 1;
            var currentUserId = Guid.NewGuid();

            IList<Comment> commentsList = new List<Comment> {};

            IList<ApplicationUser> usersList = new List<ApplicationUser> {};

            var commentsListMock = commentsList.BuildMock();
            var usersListMock = usersList.BuildMock();

            this.commentRepository.Setup(repo => repo.GetAllAttached())
                .Returns(commentsListMock);
            this.userRepository.Setup(repo => repo.GetAllAttached())
                .Returns(usersListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);

            var result = await homeService.GetCommentsBySongId(songId, currentUserId);

            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task IndexGetAllPlaylistsReturnsAllPlaylists()
        {
            IList<PlayList> playlistsList = new List<PlayList>
            {
                new PlayList { Id = 1, Name = "Chill Vibes", ApplicationUserId = Guid.NewGuid() },
                new PlayList { Id = 2, Name = "Workout Mix", ApplicationUserId = Guid.NewGuid() }
            };

            var playlistsListMock = playlistsList.BuildMock();

            this.playlistRepository.Setup(repo => repo.GetAllAttached())
                .Returns(playlistsListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);
            
            var result = await homeService.IndexGetAllPlaylists();

            Assert.IsNotNull(result);
            var resultList = result.ToList();
            Assert.That(resultList.Count, Is.EqualTo(2));

            Assert.That(resultList[0].Id, Is.EqualTo("1"));
            Assert.That(resultList[0].Name, Is.EqualTo("Chill Vibes"));

            Assert.That(resultList[1].Id, Is.EqualTo("2"));
            Assert.That(resultList[1].Name, Is.EqualTo("Workout Mix"));
        }

        [Test]
        public async Task IndexGetAllPlaylistsReturnsEmptyWhenNoPlaylistsExist()
        {
            IList<PlayList> emptyPlaylistsList = new List<PlayList> {};

            var emptyPlaylistsListMock = emptyPlaylistsList.BuildMock();

            this.playlistRepository.Setup(repo => repo.GetAllAttached())
                .Returns(emptyPlaylistsListMock);

            IHomeService homeService = new HomeService(playlistRepository.Object, artistRepository.Object, songRepository.Object, commentRepository.Object, userRepository.Object);
            
            var result = await homeService.IndexGetAllPlaylists();

            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }
    }
}
