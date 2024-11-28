using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NoteLy.Data;
using NoteLy.Data.Models;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
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
        public IActionResult Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return Json(new { success = false});
            }

            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            // Search playlists by name
            var playlists = _dbContext.PlayLists
                .Where(p => p.Name.Contains(query))
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.ApplicationUserId
                })
                .ToList();

            return Json(new { success = true, playlists, userId});
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

            // Retrieve the playlist including its songs and their comments
            var playlist = await _dbContext.PlayLists
                .Include(p => p.Songs)
                .ThenInclude(s => s.Comments)
                .FirstOrDefaultAsync(p => p.Id == id && p.ApplicationUserId == userId);

            if (playlist == null)
            {
                return NotFound();
            }

            // Remove comments related to each song
            foreach (var song in playlist.Songs)
            {
                _dbContext.Comments.RemoveRange(song.Comments);
            }

            // Remove associated songs
            _dbContext.Songs.RemoveRange(playlist.Songs);

            // Remove the playlist
            _dbContext.PlayLists.Remove(playlist);

            // Save changes to the database
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
