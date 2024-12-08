using Moq;
using Notely.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data;
using NoteLy.Services.Data.Interfaces;

namespace NoteLy.Services.Tests
{
    [TestFixture]
    public class SongControlsServiceTests
    {
        private Mock<IRepository<Song, int>> songRepository;

        [SetUp]
        public void SetUp()
        {
            this.songRepository = new Mock<IRepository<Song, int>>();
        }

        [Test]
        public void GetSongTest()
        {
            var songId = 1;
            var expectedSong = new Song { Id = songId, Name = "Song Title" };

            this.songRepository
                .Setup(repo => repo.GetById(songId))
                .Returns(expectedSong);

            ISongControlsService songControlsService = new SongControlsService(songRepository.Object);

            var result = songControlsService.GetSong(songId);

            Assert.That(result, Is.Not.Null);
            Assert.That(result?.Id, Is.EqualTo(expectedSong.Id));
            Assert.That(result?.Name, Is.EqualTo(expectedSong.Name));
        }
    }
}
