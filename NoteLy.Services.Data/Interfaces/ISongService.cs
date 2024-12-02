using NoteLy.Data.Models;
using NoteLy.Web.ViewModels.Song;

namespace NoteLy.Services.Data.Interfaces
{
    public interface ISongService
    {
        Task<List<PlayList>> GetAllPlaylists();

        Task DeleteSongAsync(int id);

        Task<EditSongViewModel> GetEditSongViewModelAsync(int id);

        Task<(bool Success, string ErrorMessage)> UpdateSongAsync(EditSongViewModel model);

        Task<(bool success, string fieldForErrorMessage, string errorMessage)> CreateSongAsync(string selectedPlaylistId, AddSongInputModel songViewModel, Guid currentUserId);
    }
}
