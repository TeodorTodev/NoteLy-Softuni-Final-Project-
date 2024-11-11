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
        public async Task<IActionResult> GetSongs()
        {
            var songs = await _dbContext.Songs.ToListAsync();
            return Json(songs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string SelectedSongId, AddCommentInputModel inputModel)
        {

            if (string.IsNullOrEmpty(SelectedSongId))
            {
                ModelState.AddModelError("SelectedSongId", "Please select a song.");
                return View(inputModel); // Return the view with the error message
            }

            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            Comment comment = new Comment()
            {
                Text = inputModel.Text,
                SongId = int.Parse(SelectedSongId),
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
