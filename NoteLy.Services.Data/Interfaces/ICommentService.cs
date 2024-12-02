using Notely.Data.Models;
using NoteLy.Web.ViewModels.Comment;

namespace NoteLy.Services.Data.Interfaces
{
    public interface ICommentService
    {
        Task<List<Song>> GetAllSongsAsync();

        Task AddCommentAsync(string id, AddCommentInputModel model, Guid currentUserId);

        Task<Comment?> GetCommentById(int id);
        Task EditCommentAsync(EditCommentViewModel model);

        Task<bool> DeleteCommentAsync(int id);
    }
}
