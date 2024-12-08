using Microsoft.IdentityModel.Tokens;
using MockQueryable;
using Moq;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Services.Tests
{
    [TestFixture]
    public class PlaylistServiceTests
    {
        private Mock<IRepository<Song, int>> songRepository;
        private Mock<IRepository<PlayList, int>> playlistRepository;
        private Mock<IRepository<Comment, int>> commentRepository;

        [SetUp]
        public void SetUp()
        {
            this.songRepository = new Mock<IRepository<Song, int>>();
            this.playlistRepository = new Mock<IRepository<PlayList, int>>();
            this.commentRepository = new Mock<IRepository<Comment, int>>();
        }

        [Test]
        public async Task DeletePlaylistsWithSongsAndComments()
        {
            var playlistId = 1;
            var currentUserId = Guid.NewGuid();

            var mockComments1 = new List<Comment> { new Comment { Id = 1 }, new Comment { Id = 2 } };
            var mockComments2 = new List<Comment> { new Comment { Id = 3 } };

            var mockSongs = new List<Song>
            {
                new Song { Id = 1, Comments = mockComments1 },
                new Song { Id = 2, Comments = mockComments2 }
            };

            IList<PlayList> playlists = new List<PlayList>()
            {
                new PlayList
                {
                    Id = playlistId,
                    ApplicationUserId = currentUserId,
                    Songs = mockSongs
                }
            };

            var playlistsMock = playlists.BuildMock();

            this.playlistRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(playlistsMock);

            this.commentRepository
                .Setup(repo => repo.DeleteRangeAsync(It.IsAny<IEnumerable<Comment>>()))
                .Returns(Task.CompletedTask);

            this.songRepository
                .Setup(repo => repo.DeleteRangeAsync(It.IsAny<IEnumerable<Song>>()))
                .Returns(Task.CompletedTask);

            this.playlistRepository
                .Setup(repo => repo.DeleteAsync(playlistId))
                .Returns(Task.FromResult(true));

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            await playlistService.DeletePlaylistAsync(playlistId, currentUserId);

            this.commentRepository.Verify(
                repo => repo.DeleteRangeAsync(It.Is<IEnumerable<Comment>>(c => c.SequenceEqual(mockComments1))),
                Times.Once
            );

            this.commentRepository.Verify(
                repo => repo.DeleteRangeAsync(It.Is<IEnumerable<Comment>>(c => c.SequenceEqual(mockComments2))),
                Times.Once
            );

            this.songRepository.Verify(
                repo => repo.DeleteRangeAsync(It.Is<IEnumerable<Song>>(s => s.SequenceEqual(mockSongs))),
                Times.Once
            );

            this.playlistRepository.Verify(repo => repo.DeleteAsync(playlistId), Times.Once);
        }

        [Test]
        public async Task GetPlaylistsByQueryMatchingQuery()
        {
            var query = "test";
            var expectedPlaylists = 2;
            var playlistsList = new List<PlayList>
            {
                new PlayList { Id = 1, Name = "test playlist 1", ApplicationUserId = Guid.NewGuid() },
                new PlayList { Id = 2, Name = "another playlist", ApplicationUserId = Guid.NewGuid() },
                new PlayList { Id = 3, Name = "test playlist 2", ApplicationUserId = Guid.NewGuid() },
            };

            var playlistsMock = playlistsList.BuildMock();

            this.playlistRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(playlistsMock);

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            var result = await playlistService.GetPlaylistsByQuery(query);

            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(expectedPlaylists));
            Assert.That(result.Any(p => p.Name == "test playlist 1"), Is.True);
            Assert.That(result.Any(p => p.Name == "test playlist 2"), Is.True);
        }

        [Test]
        public async Task GetPlaylistsByQueryNonMatchingQuery()
        {
            var query = "nonexistent";
            var expectedPlaylists = 0;
            var playlistsList = new List<PlayList>
            {
                new PlayList { Id = 1, Name = "test playlist 1", ApplicationUserId = Guid.NewGuid() },
                new PlayList { Id = 2, Name = "another playlist", ApplicationUserId = Guid.NewGuid() },
                new PlayList { Id = 3, Name = "test playlist 2", ApplicationUserId = Guid.NewGuid() },
            };

            var playlistsMock = playlistsList.BuildMock();

            this.playlistRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(playlistsMock);

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            var result = await playlistService.GetPlaylistsByQuery(query);

            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(expectedPlaylists));
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task AddPlaylistAsyncTest()
        {
            var addPlaylistInputModel = new AddPlayListInputModel
            {
                Name = "My Playlist"
            };
            var currentUserId = Guid.NewGuid();

            this.playlistRepository
                .Setup(repo => repo.AddAsync(It.IsAny<PlayList>()))
                .Returns(Task.CompletedTask);

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            await playlistService.AddPlaylistAsync(addPlaylistInputModel, currentUserId);

            this.playlistRepository.Verify(
                repo => repo.AddAsync(It.Is<PlayList>(p =>
                    p.Name == addPlaylistInputModel.Name &&
                    p.ApplicationUserId == currentUserId)),
                Times.Once
            );
        }

        [Test]
        public async Task EditPlaylistAsyncTest()
        {
            var playlistId = 1;
            var existingPlaylist = new PlayList
            {
                Id = playlistId,
                Name = "Old Playlist Name",
                ApplicationUserId = Guid.NewGuid()
            };

            var editModel = new EditPlaylistViewModel
            {
                Id = playlistId,
                Name = "New Playlist Name"
            };

            this.playlistRepository
                .Setup(repo => repo.GetByIdAsync(playlistId))
                .ReturnsAsync(existingPlaylist);

            this.playlistRepository
                .Setup(repo => repo.UpdateAsync(It.IsAny<PlayList>()))
                .Returns(Task.FromResult(true));

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            await playlistService.EditPlaylistAsync(editModel);

            Assert.That(existingPlaylist.Name, Is.EqualTo(editModel.Name), "The playlist name should be updated.");
        }

        [Test]
        public async Task GetPlaylistByValidId()
        {
            var playlistId = 1;
            var expectedPlaylist = new PlayList
            {
                Id = playlistId,
                Name = "Test Playlist",
                ApplicationUserId = Guid.NewGuid()
            };

            this.playlistRepository
                .Setup(repo => repo.GetByIdAsync(playlistId))
                .ReturnsAsync(expectedPlaylist);

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            var result = await playlistService.GetPlaylistById(playlistId);

            Assert.That(result, Is.Not.Null, "The method should return a playlist when the ID exists.");
            Assert.That(result, Is.EqualTo(expectedPlaylist), "The returned playlist should match the expected playlist.");
        }

        [Test]
        public async Task GetPlaylistById_ShouldReturnNull_WhenIdDoesNotExist()
        {
            var playlistId = 1;

            this.playlistRepository
                .Setup(repo => repo.GetByIdAsync(playlistId))
                .ReturnsAsync((PlayList?)null);

            IPlaylistService playlistService = new PlaylistService(playlistRepository.Object, commentRepository.Object, songRepository.Object);

            // Act
            var result = await playlistService.GetPlaylistById(playlistId);

            // Assert
            Assert.IsNull(result, "The method should return null when the ID does not exist.");

            this.playlistRepository.Verify(repo => repo.GetByIdAsync(playlistId), Times.Once);
        }
    }
}
