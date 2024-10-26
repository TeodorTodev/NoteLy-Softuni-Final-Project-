using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using NoteLy.Web.ViewModels.Song;
using Notely.Data.Models;
using System.Security.Claims;
using NuGet.Packaging;
using System.Collections.Generic;

namespace NoteLy.Web.Controllers
{
    public class SongController : Controller
    {
        private readonly NoteLyDbContext _dbContext;
        public SongController(NoteLyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddSongInputModel songViewModel, List<string> artistNames)
        {
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
                PlayListId = playlist.Id
            };

            _dbContext.Songs.Add(newSong);
            await _dbContext.SaveChangesAsync();

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

            // Prepare the view model with the song details, including FilePath
            var viewModel = new EditSongViewModel
            {
                Id = song.Id,
                Name = song.Name,
                Duration = song.Duration,
                FilePath = song.FilePath,  // Populate FilePath
                ArtistNames = song.Artists.Select(a => a.Artist.UserName).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditSongViewModel model)
        {
            //var song = await _dbContext.Songs
            //.Include(s => s.Artists)  // Load artists associated with the song
            //.FirstOrDefaultAsync(s => s.Id == model.Id);

            //if (song == null)
            //{
            //    return NotFound();  // Return 404 if the song doesn't exist
            //}

            //// Update song properties
            //song.Name = model.Name;
            //song.Duration = model.Duration;
            //song.FilePath = model.FilePath;

            //// Handle updating artists
            //var selectedArtistIds = model.SelectedArtistIds;  // The list of selected artist IDs

            //if (selectedArtistIds != null && selectedArtistIds.Count > 0)
            //{
            //    // Fetch the selected artists from the database
            //    var selectedArtists = await _dbContext.Artists
            //        .Where(a => selectedArtistIds.Contains(a.Id))
            //        .ToListAsync();

            //    // Clear existing artist relationships
            //    song.Artists.Clear();

            //    // Add the selected artists to the song
            //    song.Artists.AddRange(selectedArtists);
            //}
            //else
            //{
            //    // If no artists are selected, clear the current associations
            //    song.Artists.Clear();
            //}

            //// Save changes to the database
            //await _dbContext.SaveChangesAsync();

            //// Redirect to the Index or another page
            //return RedirectToAction("Index", "Home");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var song = await _dbContext.Songs
                .FirstOrDefaultAsync(s => s.Id == id);

            _dbContext.Songs.Remove(song);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
