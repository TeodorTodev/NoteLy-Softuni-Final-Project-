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
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddSongInputModel songViewModel)
        {
            var userId = Guid.Parse(userManager.GetUserId(User));
            if (!_dbContext.PlayLists.Any(p => p.Name == songViewModel.PlayListName))
            {
                return RedirectToAction("Index", "Home");
            }
            var playlist = _dbContext.PlayLists.FirstOrDefault(p => p.Name == songViewModel.PlayListName);
            var newSong = new Song
            {
                Name = songViewModel.Name,
                Duration = songViewModel.Duration,
                FilePath = songViewModel.FilePath,
                PlayListId = playlist.Id,
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
                .Include(s => s.Artists)  // Include associated artists
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
            .Where(a => artistsIds.Contains(a.Id)) // Filter for the given IDs
            .Select(a => a.UserName) // Select the UserName property
            .ToListAsync(); // Execute the query

            // Prepare the view model with the song details, including FilePath
            var viewModel = new EditSongViewModel
            {
                Id = song.Id,
                Name = song.Name,
                Duration = song.Duration,
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
                .Include(s => s.Artists) // Include existing artists
                .FirstOrDefaultAsync(s => s.Id == model.Id);

            if (song == null)
            {
                return RedirectToAction("Index", "Home");
            }

            // Update the song properties
            song.Name = model.Name;
            song.Duration = model.Duration;
            song.FilePath = model.FilePath;

            // Split artist names into a list and trim whitespace
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
                        // Set other properties if necessary
                    };

                    // Add the new artist to the context
                    await _dbContext.Artists.AddAsync(newArtist);
                    await _dbContext.SaveChangesAsync();

                    // Create the relationship with the song
                    song.Artists.Add(new ArtistSong { SongId = song.Id, ArtistId = newArtist.Id });
                }
            }

            // Save changes to the database
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            //var song = await _dbContext.Songs
            //    .FirstOrDefaultAsync(s => s.Id == id);

            //_dbContext.Songs.Remove(song);
            //await _dbContext.SaveChangesAsync();

            //return RedirectToAction("Index", "Home");


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
