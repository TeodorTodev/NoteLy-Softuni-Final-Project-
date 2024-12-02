using NoteLy.Data.Models;
using NoteLy.Web.ViewModels.Playlist;

namespace NoteLy.Services.Data.Interfaces
{
    public interface IPlaylistService
    {
        Task<List<SearchPlaylistViewModel>> GetPlaylistsByQuery(string query);

        Task AddPlaylistAsync(AddPlayListInputModel inputModel, Guid currentUserId);

        Task<PlayList?> GetPlaylistById(int id);

        Task EditPlaylistAsync(EditPlaylistViewModel model);

        Task DeletePlaylistAsync(int id, Guid currentUserId);
    }
}
