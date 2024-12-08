using Microsoft.EntityFrameworkCore;
using MockQueryable;
using Moq;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Services.Tests
{
    [TestFixture]
    public class CommentServiceTests
    {
        private Mock<IRepository<Song, int>> songRepository;
        private Mock<IRepository<Comment, int>> commentRepository;

        [SetUp]
        public void SetUp()
        {
            this.songRepository = new Mock<IRepository<Song, int>>();
            this.commentRepository = new Mock<IRepository<Comment, int>>();
        }

        [Test]
        public async Task AddCommentAsyncTest()
        {
            var addCommentInputModel = new AddCommentInputModel
            {
                Text = "This is a comment"
            };
            var currentUserId = Guid.NewGuid();
            var songId = "1";

            this.commentRepository.Setup(repo => repo.AddAsync(It.IsAny<Comment>()))
                .Returns(Task.CompletedTask);

            ICommentService commentService = new CommentService(commentRepository.Object, songRepository.Object);

            await commentService.AddCommentAsync(songId, addCommentInputModel, currentUserId);

            this.commentRepository.Verify(repo => repo.AddAsync(It.IsAny<Comment>()), Times.Once);
        }

        [Test]
        public async Task DeleteCommentAsyncTest()
        {
            var commentId = 1;
            var comment = new Comment { Id = commentId, Text = "This is a comment" };

            this.commentRepository
                .Setup(repo => repo.GetByIdAsync(commentId))
                .ReturnsAsync(comment);

            this.commentRepository
                .Setup(repo => repo.DeleteAsync(commentId))
                .Returns(Task.FromResult(true));

            ICommentService commentService = new CommentService(commentRepository.Object, songRepository.Object);

            var result = await commentService.DeleteCommentAsync(commentId);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task EditCommentAsyncTest()
        {
            var commentId = 1;
            var existingComment = new Comment { Id = commentId, Text = "Original comment text" };
            var editCommentViewModel = new EditCommentViewModel { Id = commentId, Text = "Updated comment text" };

            this.commentRepository.Setup(repo => repo.GetByIdAsync(commentId))
                .ReturnsAsync(existingComment);

            this.commentRepository.Setup(repo => repo.UpdateAsync(It.IsAny<Comment>()))
                .Returns(Task.FromResult(true));

            ICommentService commentService = new CommentService(commentRepository.Object, songRepository.Object);

            await commentService.EditCommentAsync(editCommentViewModel);

            Assert.That(existingComment.Text, Is.EqualTo("Updated comment text"));
        }

        [Test]
        public async Task GetAllSongsAsyncPositive()
        {
            IList<Song> songsList = new List<Song>
            {
                new Song { Id = 1, Name = "Song 1" },
                new Song { Id = 2, Name = "Song 2" }
            };

            var songsListMock = songsList.BuildMock();

            this.songRepository
                .Setup(repo => repo.GetAllAttached())
                .Returns(songsListMock);

            ICommentService commentService = new CommentService(commentRepository.Object, songRepository.Object);

            var result = await commentService.GetAllSongsAsync();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Name, Is.EqualTo("Song 1"));
            Assert.That(result[1].Name, Is.EqualTo("Song 2"));
        }

        [Test]
        public async Task GetAllSongsAsyncNegative()
        {
            var expectedSongsCount = 0;

            var emptySongsList = new List<Song>();

            var emptySongsListMock = emptySongsList.BuildMock();

            this.songRepository.Setup(repo => repo.GetAllAttached())
                .Returns(emptySongsListMock);

            ICommentService commentService = new CommentService(commentRepository.Object, songRepository.Object);

            var result = await commentService.GetAllSongsAsync();

            Assert.That(result.Count, Is.EqualTo(expectedSongsCount));
        }

        [Test]
        public async Task GetCommentByIdTest()
        {
            var commentId = 1;
            var expectedComment = new Comment { Id = commentId, Text = "This is a comment" };

            this.commentRepository
                .Setup(repo => repo.GetByIdAsync(commentId))
                .ReturnsAsync(expectedComment);

            ICommentService commentService = new CommentService(commentRepository.Object, songRepository.Object);

            var result = await commentService.GetCommentById(commentId);

            Assert.That(result, Is.Not.Null);
            Assert.That(result?.Id, Is.EqualTo(expectedComment.Id));
            Assert.That(result?.Text, Is.EqualTo(expectedComment.Text));
        }
    }
}
