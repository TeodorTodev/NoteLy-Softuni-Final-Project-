using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            return RedirectToAction("Index", "Home", new { songId = comment.SongId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var comment = await _dbContext.Comments.FindAsync(id);

            var viewModel = new EditCommentViewModel
            {
                Id = comment.Id,
                Text = comment.Text,
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditCommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var comment = await _dbContext.Comments.FindAsync(model.Id);
                if (comment == null)
                {
                    return this.RedirectToAction("Index", "Home");
                }

                comment.Text = model.Text;

                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Home", new { songId = comment.SongId });
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var comment = await _dbContext.Comments
                .FirstOrDefaultAsync(s => s.Id == id);

            if (comment == null)
            {
                return RedirectToAction("Index", "Home");
            }

            _dbContext.Comments.Remove(comment);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home", new { songId = comment.SongId });
        }
    }
}
