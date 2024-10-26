using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using NoteLy.Data.Models;
using NoteLy.Web.ViewModels.Playlist;
using System.Security.Claims;

namespace NoteLy.Web.Controllers
{
    public class PlayListController : Controller
    {
        private readonly NoteLyDbContext _dbContext;
        public PlayListController(NoteLyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddPlayListInputModel inputModel)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            PlayList playList = new PlayList()
            {
                Name = inputModel.Name,
                ApplicationUserId = userId
            };

            await this._dbContext.PlayLists.AddAsync(playList);
            await this._dbContext.SaveChangesAsync();

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var playlist = await _dbContext.PlayLists
                .FirstOrDefaultAsync(p => p.Id == id);

            var model = new EditPlaylistViewModel
            {
                Id = playlist.Id,
                Name = playlist.Name
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditPlaylistViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var playlist = await _dbContext.PlayLists
                .FirstOrDefaultAsync(p => p.Id == model.Id);

            playlist.Name = model.Name;

            _dbContext.PlayLists.Update(playlist);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var playlist = await _dbContext.PlayLists
                .FirstOrDefaultAsync(p => p.Id == id && p.ApplicationUserId == userId);

            _dbContext.PlayLists.Remove(playlist);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
