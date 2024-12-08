using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Services.Data
{
    public class PlaylistService : IPlaylistService
    {
        private IRepository<PlayList, int> playlistRepository;
        private IRepository<Comment, int> commentRepository;
        private IRepository<Song, int> songRepository;

        public PlaylistService(IRepository<PlayList, int> playListRepository, IRepository<Comment, int> commentRepository, IRepository<Song, int> songRepository)
        {
            this.playlistRepository = playListRepository;
            this.commentRepository = commentRepository;
            this.songRepository = songRepository;
        }

        public async Task AddPlaylistAsync(AddPlayListInputModel inputModel, Guid currentUserId)
        {
            PlayList playList = new PlayList()
            {
                Name = inputModel.Name,
                ApplicationUserId = currentUserId
            };

            await this.playlistRepository.AddAsync(playList);
        }

        public async Task DeletePlaylistAsync(int id, Guid currentUserId)
        {
            var playlist = await this.playlistRepository
                .GetAllAttached()
                .Include(p => p.Songs)
                .ThenInclude(s => s.Comments)
                .FirstOrDefaultAsync(p => p.Id == id && p.ApplicationUserId == currentUserId);

            // Remove comments related to each song
            foreach (var song in playlist.Songs)
            {
                await commentRepository.DeleteRangeAsync(song.Comments);
            }

            // Remove associated songs
            await songRepository.DeleteRangeAsync(playlist.Songs);

            // Remove the playlist
            await playlistRepository.DeleteAsync(id);
        }

        public async Task EditPlaylistAsync(EditPlaylistViewModel model)
        {
            var playlist = await this.playlistRepository.GetByIdAsync(model.Id);

            playlist.Name = model.Name;

            await this.playlistRepository.UpdateAsync(playlist);
        }

        public async Task<PlayList?> GetPlaylistById(int id)
        {
            PlayList? playlist = await this.playlistRepository.GetByIdAsync(id);
            return playlist;
        }

        public async Task<List<SearchPlaylistViewModel>> GetPlaylistsByQuery(string query)
        {
            List<SearchPlaylistViewModel> playlists = await this.playlistRepository.GetAllAttached()
                .Where(p => p.Name.Contains(query))
                .Select(p => new SearchPlaylistViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    ApplicationUserId = p.ApplicationUserId
                })
                .ToListAsync();
            return playlists;
        }
    }
}
