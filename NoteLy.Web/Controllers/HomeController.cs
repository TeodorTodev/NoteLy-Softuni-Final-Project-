using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using NoteLy.Data.Models;
using NoteLy.Web.ViewModels;
using NoteLy.Web.ViewModels.Comment;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
using System.Diagnostics;
using System.Security.Claims;

namespace NoteLy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoteLyDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        public HomeController(NoteLyDbContext _dbContext, UserManager<ApplicationUser> _userManager)
        {
            this.dbContext = _dbContext;
            this.userManager = _userManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //var userId = Guid.Parse(userManager.GetUserId(User));
            IEnumerable<CollectionCardViewModel> playlists = await this.dbContext
                .PlayLists
                //.Where(p => p.ApplicationUserId == userId)
                .Select(c => new CollectionCardViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    ApplicationUserId = c.ApplicationUserId,
                })
                .ToListAsync();

            

            

            var viewModel = new CompositeViewModel
            {
                PlayLists = playlists,
                //Songs = songs,
                //Comments = comments
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
            //IEnumerable<CollectionCardViewModel> playlists = await this.dbContext
            //    .PlayLists
            //    .Select(c => new CollectionCardViewModel()
            //    {
            //        Id = c.Id.ToString(),
            //        Name = c.Name,
            //        CollectionType = c.CollectionType
            //    })
            //    .ToArrayAsync();

            //IEnumerable<CollectionCardViewModel> albums = await this.dbContext
            //    .Albums
            //    .Select(a => new CollectionCardViewModel()
            //    {
            //        Id = a.Id.ToString(),
            //        Name = a.Name,
            //        CollectionType = a.CollectionType
            //    })
            //    .ToArrayAsync();


            //IEnumerable<CollectionCardViewModel> combinedCollection = playlists
            //    .Concat(albums)
            //    .OrderBy(c => c.Id);

            return View(); // combinedCollection

        }

        public async Task<IActionResult> SongsSection(int playlistId)
        {
            //var userId = Guid.Parse(userManager.GetUserId(User));
            //IEnumerable<SongCardViewModel> songs = await this.dbContext
            //    .Songs
            //    .Where(s => s.PlayListId == playlistId)
            //    .Select(s => new SongCardViewModel()
            //    {
            //        Id = s.Id.ToString(),
            //        Name = s.Name,
            //        Artists = s.Artists.Select(a => a.Artist.UserName).ToArray(),
            //        Duration = s.Duration,
            //    })
            //    .ToListAsync();

            var playlist = await dbContext.PlayLists
            .Include(p => p.Songs)
            .ThenInclude(s => s.Artists)
            .ThenInclude(a => a.Artist) // Load artists via the ArtistsSongs mapping table
            .FirstOrDefaultAsync(p => p.Id == playlistId);

            if (playlist == null)
            {
                return NotFound();
            }

            // Get the current user's ID
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Prepare the songs data to send back
            var songs = playlist.Songs.Select(s => new SongCardViewModel()
            {
                Id = s.Id.ToString(),
                Name = s.Name,
                Artists = s.Artists.Select(a => a.Artist.UserName).ToArray(),
                Duration = s.Duration,
                IsCreator = s.ApplicationUserId.ToString() == currentUserId,
                IsPlaylistCreator = playlist.ApplicationUserId.ToString() == currentUserId
            });

            //return View(songs); // songs
            return Json(songs);
        }

        public async Task<IActionResult> CommentSection(int songId)
        {
            var currentUserId = Guid.Parse(userManager.GetUserId(User));
            IEnumerable<CommentCardViewModel> comments = await this.dbContext
                .Comments
                .Where(c => c.SongId == songId)
                .Select(s => new CommentCardViewModel()
                {
                    Id = s.Id.ToString(),
                    Text = s.Text,
                    ApplicationUserName = dbContext.Users.FirstOrDefault(u => u.Id == s.ApplicationUserId).UserName,
                    IsCreator = s.ApplicationUserId == currentUserId
                })
                .ToListAsync();

            //return View(comments);
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}