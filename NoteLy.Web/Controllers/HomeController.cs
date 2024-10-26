using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using NoteLy.Web.ViewModels;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;
using System.Diagnostics;

namespace NoteLy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoteLyDbContext dbContext;
        public HomeController(NoteLyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<CollectionCardViewModel> playlists = await this.dbContext
                .PlayLists
                .Select(c => new CollectionCardViewModel()
                {
                    Name = c.Name,
                })
                .ToListAsync();

            IEnumerable<SongCardViewModel> songs = await this.dbContext
                .Songs
                .Select(s => new SongCardViewModel()
                {
                    Id = s.Id.ToString(),
                    Name = s.Name,
                    Artists = s.Artists.Select(a => a.Artist.UserName).ToArray(),
                    Duration = s.Duration,
                })
                .ToListAsync();

            var viewModel = new CompositeViewModel
            {
                PlayLists = playlists,
                Songs = songs
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

        public IActionResult SongsSection()
        {
            //IEnumerable<SongCardViewModel> songs = await this.dbContext
            //    .Songs
            //    .Include(s => s.Album)
            //    .Select(c => new SongCardViewModel()
            //    {
            //        Id = c.Id.ToString(),
            //        Name = c.Name,
            //        Artists = c.Artists.Select(a => a.Artist.UserName).ToArray(),
            //        AlbumName = c.Album.Name
            //    })
            //    .ToArrayAsync();

            return View(); // songs
        }

        public IActionResult CommentSection()
        {
            return View();
        }

        public IActionResult SongControls()
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