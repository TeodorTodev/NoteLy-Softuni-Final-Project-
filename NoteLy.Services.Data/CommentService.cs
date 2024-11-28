using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Comment;

namespace NoteLy.Services.Data
{
    public class CommentService : ICommentService
    {
        private IRepository<Comment, int> commentRepository;
        private IRepository<Song, int> songRepository;

        public CommentService(IRepository<Comment, int> commentRepository, IRepository<Song, int> songRepository)
        {
            this.commentRepository = commentRepository;
            this.songRepository = songRepository;
        }

        public async Task AddCommentAsync(string id, AddCommentInputModel model, Guid currentUserId)
        {
            Comment comment = new Comment()
            {
                Text = model.Text,
                SongId = int.Parse(id),
                ApplicationUserId = currentUserId
            };

            await this.commentRepository.AddAsync(comment);
        }

        public async Task<bool> DeleteCommentAsync(int id)
        {
            Comment comment = await this.commentRepository
                .GetByIdAsync(id);

            await this.commentRepository.DeleteAsync(comment.Id);
            return true;
        }

        public async Task<Comment?> EditCommentAsync(EditCommentViewModel model)
        {
            Comment comment = await this.commentRepository.GetByIdAsync(model.Id);
            if (comment == null)
            {
                return null;
            }

            comment.Text = model.Text;

            await this.commentRepository.UpdateAsync(comment);
            return comment;
        }

        public async Task<List<Song>> GetAllSongsAsync()
        {
            List<Song> songs = await this.songRepository.GetAllAttached().ToListAsync();
            return songs;
        }

        public async Task<Comment?> GetCommentById(int id)
        {
            Comment? comment = await this.commentRepository.GetByIdAsync(id);
            return comment;
        }
    }
}
