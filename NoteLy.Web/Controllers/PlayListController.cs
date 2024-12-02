using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NoteLy.Data;
using NoteLy.Data.Models;
using NoteLy.Services.Data;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
using System.Collections.Generic;
using System.Security.Claims;

namespace NoteLy.Web.Controllers
{
    public class PlayListController : Controller
    {
        private readonly IPlaylistService playlistService;
        private readonly UserManager<ApplicationUser> userManager;
        public PlayListController(IPlaylistService playlistService, UserManager<ApplicationUser> userManager)
        {
            this.playlistService = playlistService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return Json(new { success = false});
            }

            Guid currentUserId = Guid.Parse(userManager.GetUserId(User));

            List<SearchPlaylistViewModel> playlists = await this.playlistService.GetPlaylistsByQuery(query);

            return Json(new { success = true, playlists, currentUserId });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddPlayListInputModel inputModel)
        {
            Guid currentUserId = Guid.Parse(userManager.GetUserId(User));

            await this.playlistService.AddPlaylistAsync(inputModel, currentUserId);

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            PlayList? playlist = await this.playlistService.GetPlaylistById(id);

            EditPlaylistViewModel model = new EditPlaylistViewModel
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

            await this.playlistService.EditPlaylistAsync(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Guid currentUserId = Guid.Parse(userManager.GetUserId(User));

            await this.playlistService.DeletePlaylistAsync(id, currentUserId);

            return RedirectToAction("Index", "Home");
        }
    }
}
