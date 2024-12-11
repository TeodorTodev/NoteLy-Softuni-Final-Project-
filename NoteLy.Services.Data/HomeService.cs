using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Comment;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
using System.Security.Claims;

namespace NoteLy.Services.Data
{
    public class HomeService : IHomeService
    {
        private IRepository<PlayList, int> playListRepository;
        private IRepository<Artist, int> artistRepository;
        private IRepository<Song, int> songRepository;
        private IRepository<Comment, int> commentRepository;
        private IRepository<ApplicationUser, Guid> userRepository;

        public HomeService(IRepository<PlayList, int> playListRepository, IRepository<Artist, int> artistRepository, IRepository<Song, int> songRepository, IRepository<Comment, int> commentRepository, IRepository<ApplicationUser, Guid> userRepository)
        {
            this.playListRepository = playListRepository;
            this.artistRepository = artistRepository;
            this.songRepository = songRepository;
            this.commentRepository = commentRepository;
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<SongCardViewModel>> GetAllPlaylistsWithSongsAndArtists(int id, Guid currentUserId)
        {
            PlayList? playlist = await this.playListRepository
                .GetAllAttached()
                .Include(p => p.Songs)
                .ThenInclude(s => s.Artists)
                .ThenInclude(a => a.Artist) // Load artists via the ArtistsSongs mapping table
                .FirstOrDefaultAsync(p => p.Id == id);

            if (playlist != null)
            {
                var songs = playlist.Songs.Select(s => new SongCardViewModel()
                {
                    Id = s.Id.ToString(),
                    Name = s.Name,
                    Artists = s.Artists.Select(a => a.Artist.UserName).ToArray(),
                    Duration = s.Duration,
                    IsCreator = s.ApplicationUserId.ToString() == currentUserId.ToString(),
                    IsPlaylistCreator = playlist.ApplicationUserId.ToString() == currentUserId.ToString()
                });

                return songs;
            }
            return null;
        }

        public async Task<IEnumerable<CommentCardViewModel>> GetCommentsBySongId(int id, Guid currentUserId)
        {
            IEnumerable<CommentCardViewModel> comments = await this.commentRepository
                .GetAllAttached()
                .Where(c => c.SongId == id)
                .Select(s => new CommentCardViewModel()
                {
                    Id = s.Id.ToString(),
                    Text = s.Text,
                    ApplicationUserName = this.userRepository.GetAllAttached().FirstOrDefault(u => u.Id == s.ApplicationUserId).UserName,
                    IsCreator = s.ApplicationUserId == currentUserId
                })
                .ToListAsync();

            return comments;
        }

        public async Task<IEnumerable<CollectionCardViewModel>> IndexGetAllPlaylists()
        {
            IEnumerable<CollectionCardViewModel> playlists = await this.playListRepository
                .GetAllAttached()
                .Select(c => new CollectionCardViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ApplicationUserId = c.ApplicationUserId,
                })
                .ToListAsync();
            return playlists;
        }
    }
}
