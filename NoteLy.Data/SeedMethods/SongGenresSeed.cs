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
    public static class SongGenresSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/SongGenres.json");
            var seedData = JsonConvert.DeserializeObject<SongGenresSeedHelper>(jsonData);

            if (seedData != null && seedData.SongGenres != null)
            {
                modelBuilder.Entity<SongGenre>().HasData(seedData.SongGenres);
            }
        }
    }
}
