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

namespace NoteLy.Web.Controllers
{
    public class SongController : Controller
    {
        private readonly NoteLyDbContext _dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        public SongController(NoteLyDbContext dbContext, UserManager<ApplicationUser> _userManager)
        {
            this._dbContext = dbContext;
            this.userManager = _userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlaylists()
        {
            var playlists = await _dbContext.PlayLists.ToListAsync();
            return Json(playlists);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string SelectedPlaylistId, AddSongInputModel songViewModel)
        {
            if (string.IsNullOrEmpty(SelectedPlaylistId))
            {
                ModelState.AddModelError("SelectedPlaylistId", "Please select a playlist.");
                return View(songViewModel);
            }

            var timeParts = songViewModel.Duration.Split(':');

            if (timeParts.IsNullOrEmpty())
            {
                ModelState.AddModelError("Duration", "Please enter a valid time format.");
                return View(songViewModel);
            }

            for (int i = 0; i < timeParts.Length; i++)
            {
                if (timeParts[i].Length > 2)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(songViewModel);
                }
            }

            if (!TimeSpan.TryParse(songViewModel.Duration, out var duration))
            {
                ModelState.AddModelError("Duration", "Please enter a valid time format.");
                return View(songViewModel);
            }

            TimeSpan time = TimeSpan.Zero;

            if (timeParts.Length == 1)
            {
                if (int.Parse(timeParts[0]) > 59)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(songViewModel);
                }

                int seconds = int.Parse(timeParts[0]);

                time = new TimeSpan(0, 0, seconds);
            }
            else if (timeParts.Length == 2)
            {
                if (int.Parse(timeParts[0]) > 59 || int.Parse(timeParts[1]) > 59)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(songViewModel);
                }

                int minutes = int.Parse(timeParts[0]);
                int seconds = int.Parse(timeParts[1]);

                time = new TimeSpan(0, minutes, seconds);
            }
            else if (timeParts.Length == 3)
            {
                if (int.Parse(timeParts[0]) > 23)
                {
                    ModelState.AddModelError("Duration", "The maximum accepted hours are 23.");
                    return View(songViewModel);
                }
                else if (int.Parse(timeParts[1]) > 59 || int.Parse(timeParts[2]) > 59)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(songViewModel);
                }

                int hours = int.Parse(timeParts[0]);
                int minutes = int.Parse(timeParts[1]);
                int seconds = int.Parse(timeParts[2]);

                time = new TimeSpan(hours, minutes, seconds);
            }
            else
            {
                ModelState.AddModelError("Duration", "Please enter a valid time format.");
                return View(songViewModel);
            }

            var userId = Guid.Parse(userManager.GetUserId(User));

            var newSong = new Song
            {
                Name = songViewModel.Name,
                Duration = time,
                FilePath = songViewModel.FilePath,
                PlayListId = int.Parse(SelectedPlaylistId),
                ApplicationUserId = userId,
            };

            _dbContext.Songs.Add(newSong);
            await _dbContext.SaveChangesAsync();

            List<string> artistNames = songViewModel.ArtistNames.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToList();

            foreach (var artistName in artistNames)
            {
                var existingArtist = await _dbContext.Artists
                    .FirstOrDefaultAsync(a => a.UserName == artistName);

                if (existingArtist == null)
                {
                    var newArtist = new Artist
                    {
                        UserName = artistName
                    };

                    _dbContext.Artists.Add(newArtist);
                    await _dbContext.SaveChangesAsync();
                    existingArtist = newArtist;
                }

                var songArtist = new ArtistSong
                {
                    SongId = newSong.Id,
                    ArtistId = existingArtist.Id
                };

                _dbContext.ArtistSongs.Add(songArtist);
            }

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var song = await _dbContext.Songs
                .Include(s => s.Artists)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (song == null)
            {
                return NotFound();
            }


            var artists = song.Artists.ToList();
            var artistsIds = new List<int>();
            foreach (var artist in artists) 
            {
                artistsIds.Add(artist.ArtistId);
            }
            var usernames = await _dbContext.Artists
            .Where(a => artistsIds.Contains(a.Id))
            .Select(a => a.UserName)
            .ToListAsync();

            var viewModel = new EditSongViewModel
            {
                Id = song.Id,
                Name = song.Name,
                Duration = song.Duration.ToString(),
                FilePath = song.FilePath,
                ArtistNames = string.Join(", ", usernames),
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditSongViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var song = await _dbContext.Songs
                .Include(s => s.Artists)
                .FirstOrDefaultAsync(s => s.Id == model.Id);

            if (song == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var timeParts = model.Duration.Split(':');

            if (timeParts.IsNullOrEmpty())
            {
                ModelState.AddModelError("Duration", "Please enter a valid time format.");
                return View(model);
            }

            for (int i = 0; i < timeParts.Length; i++)
            {
                if (timeParts[i].Length > 2)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(model);
                }
            }

            if (!TimeSpan.TryParse(model.Duration, out var duration))
            {
                ModelState.AddModelError("Duration", "Please enter a valid time format.");
                return View(model);
            }

            TimeSpan time = TimeSpan.Zero;

            if (timeParts.Length == 1)
            {
                if (int.Parse(timeParts[0]) > 59)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(model);
                }

                int seconds = int.Parse(timeParts[0]);

                time = new TimeSpan(0, 0, seconds);
            }
            else if (timeParts.Length == 2)
            {
                if (int.Parse(timeParts[1]) > 59 || int.Parse(timeParts[2]) > 59)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(model);
                }

                int minutes = int.Parse(timeParts[0]);
                int seconds = int.Parse(timeParts[1]);

                time = new TimeSpan(0, minutes, seconds);
            }
            else if (timeParts.Length == 3)
            {
                if (int.Parse(timeParts[0]) > 23 || int.Parse(timeParts[1]) > 59 || int.Parse(timeParts[2]) > 59)
                {
                    ModelState.AddModelError("Duration", "Please enter a valid time format.");
                    return View(model);
                }

                int hours = int.Parse(timeParts[0]);
                int minutes = int.Parse(timeParts[1]);
                int seconds = int.Parse(timeParts[2]);

                time = new TimeSpan(hours, minutes, seconds);
            }
            else
            {
                ModelState.AddModelError("Duration", "Please enter a valid time format.");
                return View(model);
            }

            song.Name = model.Name;
            song.Duration = time;
            song.FilePath = model.FilePath;

            var artistNames = model.ArtistNames
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToList();

            foreach (var artistName in artistNames)
            {
                // Check if the artist already exists in the database
                var existingArtist = await _dbContext.Artists
                    .FirstOrDefaultAsync(a => a.UserName == artistName);

                if (existingArtist != null)
                {
                    // If the artist exists, add the relationship if it doesn't exist
                    if (!song.Artists.Any(a => a.ArtistId == existingArtist.Id))
                    {
                        song.Artists.Add(new ArtistSong { SongId = song.Id, ArtistId = existingArtist.Id });
                    }
                }
                else
                {
                    // If the artist does not exist, create a new artist and add it
                    var newArtist = new Artist
                    {
                        UserName = artistName
                    };

                    await _dbContext.Artists.AddAsync(newArtist);
                    await _dbContext.SaveChangesAsync();

                    // Create the relationship with the song
                    song.Artists.Add(new ArtistSong { SongId = song.Id, ArtistId = newArtist.Id });
                }
            }

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var song = await _dbContext.Songs
            .Include(s => s.Comments)
            .FirstOrDefaultAsync(s => s.Id == id);

            if (song == null)
            {
                return NotFound();
            }

            // Delete related comments
            if (song.Comments != null)
            {
                _dbContext.Comments.RemoveRange(song.Comments);
            }

            // Delete the song
            _dbContext.Songs.Remove(song);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
