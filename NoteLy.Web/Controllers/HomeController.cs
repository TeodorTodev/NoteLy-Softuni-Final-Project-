using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using NoteLy.Data.Models;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels;
using NoteLy.Web.ViewModels.Comment;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
using System.Diagnostics;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NoteLy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHomeService homeService;
        public HomeController(UserManager<ApplicationUser> _userManager, IHomeService homeService)
        {
            this.userManager = _userManager;
            this.homeService = homeService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            IEnumerable<CollectionCardViewModel> playlists = 
                await this.homeService.IndexGetAllPlaylists();

            var viewModel = new CompositeViewModel
            {
                PlayLists = playlists
            };

            return View(viewModel);
        }

        public IActionResult Header()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PlayListSection()
        {
            return View();
        }

        public async Task<IActionResult> SongsSection(int playlistId)
        {
            Guid currentUserId = Guid.Parse(userManager.GetUserId(User));
            IEnumerable<SongCardViewModel> songs = 
                await this.homeService.GetAllPlaylistsWithSongsAndArtists(playlistId, currentUserId);

            return Json(songs);
        }

        public async Task<IActionResult> CommentSection(int songId)
        {
            Guid currentUserId = Guid.Parse(userManager.GetUserId(User));
            IEnumerable<CommentCardViewModel> comments = 
                await this.homeService.GetCommentsBySongId(songId, currentUserId);

            return Json(comments);
        }

        public IActionResult SongControls()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return RedirectToAction("Status", new { statusCode = 500 });
        }

        public IActionResult Status(int statusCode)
        {
            Console.WriteLine(statusCode);
            switch (statusCode)
            {
                case 404:
                    return View("Status404");
                case 500:
                    return View("Status500");
                default:
                    return View("Status500");
            }
        }
    }
}