using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data;
using NoteLy.Data.Models;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Comment;
using NoteLy.Web.ViewModels.Playlist;
using System.Security.Claims;

namespace NoteLy.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICommentService commentService;
        public CommentController(UserManager<ApplicationUser> userManager, ICommentService commentService)
        {
            this.userManager = userManager;
            this.commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSongs()
        {
            List<Song> songs = await this.commentService.GetAllSongsAsync();
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
                return View(inputModel);
            }

            Guid currentUserId = Guid.Parse(userManager.GetUserId(User));
            await this.commentService.AddCommentAsync(SelectedSongId, inputModel, currentUserId);

            return RedirectToAction("Index", "Home", new { songId = int.Parse(SelectedSongId) });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Comment? comment = await this.commentService.GetCommentById(id);

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
                await this.commentService.EditCommentAsync(model);

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            bool IsDeleted = await this.commentService.DeleteCommentAsync(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
