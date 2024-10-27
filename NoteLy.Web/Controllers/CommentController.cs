using Microsoft.AspNetCore.Mvc;
using Notely.Data.Models;
using NoteLy.Data;
using NoteLy.Web.ViewModels.Comment;
using NoteLy.Web.ViewModels.Playlist;
using System.Security.Claims;

namespace NoteLy.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly NoteLyDbContext _dbContext;
        public CommentController(NoteLyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCommentInputModel inputModel)
        {
            if (!_dbContext.Songs.Any(s => s.Name == inputModel.SongName))
            {
                return RedirectToAction("Index", "Home");
            }
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var song = _dbContext.Songs.FirstOrDefault(s => s.Name == inputModel.SongName);
            Comment comment = new Comment()
            {
                Text = inputModel.Text,
                SongId = song.Id,
                ApplicationUserId = userId
            };

            await this._dbContext.Comments.AddAsync(comment);
            await this._dbContext.SaveChangesAsync();

            return this.RedirectToAction("Index", "Home");
        }

    }
}
