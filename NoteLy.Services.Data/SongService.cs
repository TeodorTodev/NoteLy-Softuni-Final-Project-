using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Notely.Data.Models;
using NoteLy.Data.Models;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data.Interfaces;
using NoteLy.Web.ViewModels.Song;

namespace NoteLy.Services.Data
{
    public class SongService : ISongService
    {
        private IRepository<Song, int> songRepository;
        private IRepository<PlayList, int> playlistRepository;
        private IRepository<Comment, int> commentRepository;
        private IRepository<Artist, int> artistRepository;

        public SongService(IRepository<Song, int> songRepository, IRepository<PlayList, int> playlistRepository, IRepository<Comment, int> commentRepository, IRepository<Artist, int> artistRepository)
        {
            this.songRepository = songRepository;
            this.playlistRepository = playlistRepository;
            this.commentRepository = commentRepository;
            this.artistRepository = artistRepository;
        }

        public async Task<(bool success, string fieldForErrorMessage, string errorMessage)> CreateSongAsync(string selectedPlaylistId, AddSongInputModel songViewModel, Guid currentUserId)
        {
            // Validation
            if (string.IsNullOrEmpty(selectedPlaylistId))
            {
                return (false, "SelectedPlaylistId", "Please select a playlist.");
            }

            var timeParts = songViewModel.Duration.Split(':');
            if (timeParts.IsNullOrEmpty())
            {
                return (false, "Duration", "Please enter a valid time format.");
            }

            TimeSpan time = ValidateAndParseDuration(timeParts);
            if (time == TimeSpan.Zero)
            {
                return (false, "Duration", "Please enter a valid time format.");
            }

            // Create the song
            var newSong = new Song
            {
                Name = songViewModel.Name,
                Duration = time,
                FilePath = songViewModel.FilePath,
                PlayListId = int.Parse(selectedPlaylistId),
                ApplicationUserId = currentUserId,
            };

            await this.songRepository.AddAsync(newSong);

            // Handle artists
            await AddArtistsToSongAsync(songViewModel.ArtistNames, newSong.Id);

            return (true, null, null); // Return success
        }

        public async Task DeleteSongAsync(int id)
        {
            var song = await this.songRepository
                .GetAllAttached()
                .Include(s => s.Comments)
                .FirstOrDefaultAsync(s => s.Id == id);

            // Delete related comments
            if (song.Comments != null)
            {
                await this.commentRepository.DeleteRangeAsync(song.Comments);
            }

            // Delete the song
            await this.songRepository.DeleteAsync(song.Id);
        }

        public async Task<List<PlayList>> GetAllPlaylists()
        {
            List<PlayList> playlists = await this.playlistRepository.GetAllAttached().ToListAsync();
            return playlists;
        }

        public async Task<EditSongViewModel> GetEditSongViewModelAsync(int id)
        {
            var song = await this.songRepository
                .GetAllAttached()
                .Include(s => s.Artists)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (song == null)
            {
                return null;
            }

            var artistIds = song.Artists.Select(a => a.ArtistId).ToList();

            var usernames = await this.artistRepository
                .GetAllAttached()
                .Where(a => artistIds.Contains(a.Id))
                .Select(a => a.UserName)
                .ToListAsync();

            return new EditSongViewModel
            {
                Id = song.Id,
                Name = song.Name,
                Duration = song.Duration.ToString(),
                FilePath = song.FilePath,
                ArtistNames = string.Join(", ", usernames),
            };
        }

        public async Task<(bool Success, string ErrorMessage)> UpdateSongAsync(EditSongViewModel model)
        {
            // Fetch the song from the database
            var song = await songRepository
                .GetAllAttached()
                .Include(s => s.Artists)
                .ThenInclude(sa => sa.Artist)
                .FirstOrDefaultAsync(s => s.Id == model.Id);
            if (song == null)
            {
                return (false, "Song not found.");
            }

            // Parse and validate the duration
            if (!TimeSpan.TryParse(model.Duration, out var duration))
            {
                return (false, "Please enter a valid time format.");
            }

            // Update song properties
            song.Name = model.Name;
            song.Duration = duration;
            song.FilePath = model.FilePath;

            // Update or add artist relationships
            var artistNames = model.ArtistNames
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToList();

            // Get the current artist IDs associated with the song
            var currentArtistIds = song.Artists.Select(sa => sa.ArtistId).ToList();

            // Track new artist IDs to be associated with the song
            var newArtistIds = new List<int>();

            foreach (var artistName in artistNames)
            {
                var existingArtist = (await artistRepository.GetAllAsync())
                    .FirstOrDefault(a => a.UserName == artistName);

                if (existingArtist != null)
                {
                    newArtistIds.Add(existingArtist.Id);

                    // If the artist is not already linked to the song, add the relationship
                    if (!song.Artists.Any(sa => sa.ArtistId == existingArtist.Id))
                    {
                        song.Artists.Add(new ArtistSong { ArtistId = existingArtist.Id, SongId = song.Id });
                    }
                }
                else
                {
                    // If the artist doesn't exist, create a new artist and add the relationship
                    var newArtist = new Artist { UserName = artistName };
                    await artistRepository.AddAsync(newArtist);

                    newArtistIds.Add(newArtist.Id);

                    song.Artists.Add(new ArtistSong { ArtistId = newArtist.Id, SongId = song.Id });
                }
            }

            // Find the artist relationships that need to be deleted (those not in the new artist list)
            var artistsToRemove = song.Artists
                .Where(sa => !newArtistIds.Contains(sa.ArtistId))
                .ToList();

            // Remove the deleted artist relationships
            foreach (var artistSong in artistsToRemove)
            {
                song.Artists.Remove(artistSong);  // Remove from the song's artist collection
            }

            // Update the song in the database
            var updateSuccess = await songRepository.UpdateAsync(song);

            return (true, null); // Indicate success with no error message
        }

        private TimeSpan ValidateAndParseDuration(string[] timeParts)
        {
            TimeSpan time = TimeSpan.Zero;

            for (int i = 0; i < timeParts.Length; i++)
            {
                if (timeParts[i].Length > 2)
                {
                    return time; // Invalid duration
                }
            }

            if (!TimeSpan.TryParse(string.Join(":", timeParts), out time))
            {
                return TimeSpan.Zero; // Invalid time format
            }

            return time;
        }

        private async Task AddArtistsToSongAsync(string artistNames, int songId)
        {
            List<string> artistNamesList = artistNames.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToList();

            var song = await songRepository
                .GetAllAttached()
                .Include(s => s.Artists)
                .ThenInclude(sa => sa.Artist)
                .FirstOrDefaultAsync(s => s.Id == songId);

            foreach (var artistName in artistNamesList)
            {
                var existingArtist = await this.artistRepository
                    .GetAllAttached()
                    .FirstOrDefaultAsync(a => a.UserName == artistName);

                if (existingArtist == null)
                {
                    var newArtist = new Artist
                    {
                        UserName = artistName
                    };

                    this.artistRepository.AddAsync(newArtist);

                    existingArtist = newArtist;
                }

                var songArtist = new ArtistSong
                {
                    SongId = songId,
                    ArtistId = existingArtist.Id
                };

                song.Artists.Add(songArtist);
            }

            await this.songRepository.UpdateAsync(song);
        }
    }
}
