using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Notely.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Data.SeedMethods
{
    public static class ArtistSongsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/ArtistSongs.json");
            var seedData = JsonConvert.DeserializeObject<ArtistSongsSeedHelper>(jsonData);

            if (seedData != null && seedData.ArtistSongs != null)
            {
                modelBuilder.Entity<ArtistSong>().HasData(seedData.ArtistSongs);
            }
        }
    }
}
