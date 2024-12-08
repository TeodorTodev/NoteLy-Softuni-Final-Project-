using MockQueryable;
using MockQueryable.Moq;
using Moq;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Song;

namespace NoteLy.Services.Tests
{
    [TestFixture]
    public class SongServiceTests
    {
        private IList<Song> songsData = new List<Song>()
        {
            new Song()
            {
                Id = 1,
                Name = "Dvamata",
                Duration = new TimeSpan(0, 4, 56),
                FilePath = "https://www.youtube.com/watch?v=Xi8P86qJeA0",
                PlayListId = 34,
                ApplicationUserId = Guid.Parse("57222DEF-100B-4DE3-9FBD-B8AD8BDB3F41"),
            },
            new Song()
            {
                Id = 2,
                Name = "Otkachalki",
                Duration = new TimeSpan(0, 4, 56),
                FilePath = "https://www.youtube.com/watch?v=gihWXWvfyxc",
                PlayListId = 34,
                ApplicationUserId = Guid.Parse("57222DEF-100B-4DE3-9FBD-B8AD8BDB3F41"),
            }
        };

        private IList<PlayList> playlistsData = new List<PlayList>()
        {
            new PlayList()
            {
                Id = 1,
                Name = "Rap",
                ApplicationUserId = Guid.Parse("57222DEF-100B-4DE3-9FBD-B8AD8BDB3F41"),
            },
            new PlayList()
            {
                Id = 2,
                Name = "Chalga",
                ApplicationUserId = Guid.Parse("57222DEF-100B-4DE3-9FBD-B8AD8BDB3F41"),
            }
        };

        private IList<ArtistSong> artistSongsData = new List<ArtistSong>()
        {
            new ArtistSong()
            {
                ArtistId = 1,
                SongId = 1,
            },
            new ArtistSong()
            {
                ArtistId = 2,
                SongId = 2,
            }
        };

        private IList<Artist> artistsData = new List<Artist>()
        {
            new Artist()
            {
                Id= 1,
                UserName = "Test Artist1"
            },
            new Artist()
            {
                Id= 2,
                UserName = "Test Artist2"
            }
        };

        private Mock<IRepository<Song, int>> songRepository;
        private Mock<IRepository<PlayList, int>> playlistRepository;
        private Mock<IRepository<Artist, int>> artistRepository;
        private Mock<IRepository<Comment, int>> commentRepository;
        private Mock<IRepository<ArtistSong, object>> artistSongRepository;


        [SetUp]
        public void Setup()
        {
            this.songRepository = new Mock<IRepository<Song, int>>();
            this.playlistRepository = new Mock<IRepository<PlayList, int>>();
            this.artistRepository = new Mock<IRepository<Artist, int>>();
            this.commentRepository = new Mock<IRepository<Comment, int>>();
            this.artistSongRepository = new Mock<IRepository<ArtistSong, object>>();
        }

        [Test]
        public async Task GetAllPlaylistsTest()
        {
            var playlistsDataMock = playlistsData.BuildMock();

            this.playlistRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(playlistsDataMock);

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.GetAllPlaylists();

            Assert.IsNotNull(result);
            Assert.That(playlistsDataMock.ToList(), Is.EqualTo(result));
        }

        [Test]
        public async Task CreateSongWhenArtistsExist()
        {
            var songViewModel = new AddSongInputModel
            {
                Name = "Test Song",
                Duration = "3:45",
                FilePath = "/path/to/song.mp3",
                ArtistNames = "Artist1, Artist2"
            };
            var currentUserId = Guid.NewGuid();
            var selectedPlaylistId = "1";

            var mockSong = new Song
            {
                Id = 1,
                Name = songViewModel.Name,
                Duration = TimeSpan.Parse(songViewModel.Duration),
                FilePath = songViewModel.FilePath,
                PlayListId = int.Parse(selectedPlaylistId),
                ApplicationUserId = currentUserId
            };

            var artistsList = new List<Artist>
            {
                new Artist()
                {
                    Id= 1,
                    UserName = songViewModel.ArtistNames.Split(", ")[0],
                },
                new Artist()
                {
                    Id= 2,
                    UserName = songViewModel.ArtistNames.Split(", ")[1],
                }
            };

            var artistsListMock = artistsList.BuildMock();

            var songList = new List<Song> { mockSong };
            var songListMock = songList.BuildMock();

            songRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(songListMock);

            songRepository
                .Setup(repo => repo.AddAsync(It.IsAny<Song>()))
                .Callback<Song>(song => song.Id = mockSong.Id)
                .Returns(Task.CompletedTask);

            songRepository
                .Setup(repo => repo.UpdateAsync(It.IsAny<Song>()))
                .Returns(Task.FromResult(true));

            artistRepository
                .Setup(repo => repo.AddAsync(It.IsAny<Artist>()))
                .Returns(Task.CompletedTask);

            artistRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(artistsListMock);

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            Assert.True(result.success);
            Assert.Null(result.fieldForErrorMessage);
            Assert.Null(result.errorMessage);
        }

        [Test]
        public async Task CreateSongWhenArtistsDontExist()
        {
            var songViewModel = new AddSongInputModel
            {
                Name = "Test Song",
                Duration = "3:45",
                FilePath = "/path/to/song.mp3",
                ArtistNames = "Artist1, Artist2"
            };
            var currentUserId = Guid.NewGuid();
            var selectedPlaylistId = "1";

            var mockSong = new Song
            {
                Id = 1,
                Name = songViewModel.Name,
                Duration = TimeSpan.Parse(songViewModel.Duration),
                FilePath = songViewModel.FilePath,
                PlayListId = int.Parse(selectedPlaylistId),
                ApplicationUserId = currentUserId
            };

            var artistsList = new List<Artist> { };

            var artistsListMock = artistsList.BuildMock();

            var songList = new List<Song> { mockSong };
            var songListMock = songList.BuildMock();

            songRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(songListMock);

            songRepository
                .Setup(repo => repo.AddAsync(It.IsAny<Song>()))
                .Callback<Song>(song => song.Id = mockSong.Id)
                .Returns(Task.CompletedTask);

            songRepository
                .Setup(repo => repo.UpdateAsync(It.IsAny<Song>()))
                .Returns(Task.FromResult(true));

            int artistIdCounter = 1;
            artistRepository
                .Setup(repo => repo.AddAsync(It.IsAny<Artist>()))
                .Callback<Artist>(artist => artist.Id = artistIdCounter++)
                .Returns(Task.CompletedTask);

            artistRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(artistsListMock);

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            Assert.True(result.success);
            Assert.Null(result.fieldForErrorMessage);
            Assert.Null(result.errorMessage);
        }

        [Test]
        public async Task DontCreateSongWhenPlaylistIdNotGiven()
        {
            var songViewModel = new AddSongInputModel
            {
                Name = "Test Song",
                Duration = "3:45",
                FilePath = "/path/to/song.mp3",
                ArtistNames = "Artist1, Artist2"
            };
            var currentUserId = Guid.NewGuid();
            string selectedPlaylistId = null;

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            Assert.IsFalse(result.success);
        }

        [Test]
        public async Task DontCreateSongWhenDurationFormatNotValid()
        {
            var songViewModel = new AddSongInputModel
            {
                Name = "Test Song",
                Duration = "60:45",
                FilePath = "/path/to/song.mp3",
                ArtistNames = "Artist1, Artist2"
            };
            var currentUserId = Guid.NewGuid();
            var selectedPlaylistId = "1";

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            Assert.IsFalse(result.success);
        }

        [Test]
        public async Task DontCreateSongWhenDurationNotProvided()
        {
            var songViewModel = new AddSongInputModel
            {
                Name = "Test Song",
                Duration = ":",
                FilePath = "/path/to/song.mp3",
                ArtistNames = "Artist1, Artist2"
            };
            var currentUserId = Guid.NewGuid();
            var selectedPlaylistId = "1";

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            Assert.IsFalse(result.success);
        }

        [Test]
        public async Task DontCreateSongWhenDurationNumbersMoreThanExpected()
        {
            var songViewModel = new AddSongInputModel
            {
                Name = "Test Song",
                Duration = "456:54",
                FilePath = "/path/to/song.mp3",
                ArtistNames = "Artist1, Artist2"
            };
            var currentUserId = Guid.NewGuid();
            var selectedPlaylistId = "1";

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            var result = await songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            Assert.IsFalse(result.success);
        }

        [Test]
        [TestCase(1)]
        public async Task GetEditSongViewModelByIdPositive(int Id)
        {
            int expectedSongId = 1;
            var songsMockQueryable = songsData.BuildMock();
            var artistSongsMockQueryable = artistSongsData.BuildMock();
            var artistMockQueryable = artistsData.BuildMock();
            this.songRepository
                .Setup(r => r.GetAllAttached())
                .Returns(songsMockQueryable);

            this.artistSongRepository
                .Setup(r => r.GetAllAttached())
                .Returns(artistSongsMockQueryable);

            this.artistRepository
                .Setup(r => r.GetAllAttached())
                .Returns(artistMockQueryable);

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            EditSongViewModel songsByIdActual = await songService
               .GetEditSongViewModelAsync(Id);

            Assert.IsNotNull(songsByIdActual);
            Assert.That(songsByIdActual.Id, Is.EqualTo(expectedSongId));
        }

        [Test]
        public async Task GetEditSongViewModelByIdNegative()
        {
            var songsMockQueryable = songsData.BuildMock();
            var artistSongsMockQueryable = artistSongsData.BuildMock();
            var artistMockQueryable = artistsData.BuildMock();
            this.songRepository
                .Setup(r => r.GetAllAttached())
                .Returns(songsMockQueryable);

            this.artistSongRepository
                .Setup(r => r.GetAllAttached())
                .Returns(artistSongsMockQueryable);

            this.artistRepository
                .Setup(r => r.GetAllAttached())
                .Returns(artistMockQueryable);

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            EditSongViewModel songsByIdActual = await songService
            .GetEditSongViewModelAsync(0);

            Assert.IsNull(songsByIdActual);
        }

        [Test]
        [TestCase(1)]
        public async Task DeleteSongWithComment(int Id)
        {
            var songId = 1;

            var songsList = new List<Song>
            {
                new Song()
                {
                    Id = songId,
                    Comments = new List<Comment>
                    {
                        new Comment { Id = 1, Text = "Comment 1" },
                        new Comment { Id = 2, Text = "Comment 2" }
                    }
                },
                new Song()
                {
                    Id = songId+1,
                    Comments = new List<Comment>
                    {
                        new Comment { Id = 3, Text = "Comment 3" },
                        new Comment { Id = 4, Text = "Comment 4" }
                    }
                },
            };

            var songsListMock = songsList.BuildMock();

            this.songRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(songsListMock);

            this.commentRepository
                .Setup(repo => repo.DeleteRangeAsync(It.IsAny<IEnumerable<Comment>>()))
                .Returns(Task.CompletedTask);

            this.songRepository
                .Setup(repo => repo.DeleteAsync(songId))
                .Returns(Task.FromResult(true));

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            await songService.DeleteSongAsync(songId);

            this.commentRepository.Verify(
                repo => repo.DeleteRangeAsync(It.Is<IEnumerable<Comment>>(comments => comments.Count() == 2)),
                Times.Once);

            this.songRepository.Verify(repo => repo.DeleteAsync(songId), Times.Once);
        }

        [Test]
        public async Task DeleteSongIfItDoesntHaveComments()
        {
            var songId = 1;

            var songsList = new List<Song>
            {
                new Song()
                {
                    Id = songId,
                    Comments = null
                }
            };

            var songsListMock = songsList.BuildMock();

            this.songRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(songsListMock);

            this.songRepository
                .Setup(repo => repo.DeleteAsync(songId))
                .Returns(Task.FromResult(true));

            ISongService songService = new SongService(songRepository.Object, playlistRepository.Object, commentRepository.Object, artistRepository.Object, artistSongRepository.Object);

            await songService.DeleteSongAsync(songId);

            commentRepository.Verify(repo => repo.DeleteRangeAsync(It.IsAny<IEnumerable<Comment>>()), Times.Never);

            songRepository.Verify(repo => repo.DeleteAsync(songId), Times.Once);
        }
    }
}