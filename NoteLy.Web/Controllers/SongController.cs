using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using NoteLy.Web.ViewModels.Song;
using Notely.Data.Models;
using System.Security.Claims;
using NuGet.Packaging;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using NoteLy.Data.Models;
using Microsoft.IdentityModel.Tokens;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Services.Data;

namespace NoteLy.Web.Controllers
{
    public class SongController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ISongService songService;
        public SongController(UserManager<ApplicationUser> _userManager, ISongService songService)
        {
            this.userManager = _userManager;
            this.songService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlaylists()
        {
            List<PlayList> playlists = await this.songService.GetAllPlaylists();
            return Json(playlists);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string selectedPlaylistId, AddSongInputModel songViewModel)
        {
            var currentUserId = Guid.Parse(userManager.GetUserId(User));

            var (success, fieldForErrorMessage,errorMessage) = await this.songService.CreateSongAsync(selectedPlaylistId, songViewModel, currentUserId);

            if (!success)
            {
                ModelState.AddModelError(fieldForErrorMessage, errorMessage);
                return View(songViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            EditSongViewModel viewModel = await this.songService.GetEditSongViewModelAsync(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditSongViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var (success, errorMessage) = await this.songService.UpdateSongAsync(model);

            if (!success)
            {
                ModelState.AddModelError("Duration", errorMessage); // Add error to ModelState
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await this.songService.DeleteSongAsync(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
