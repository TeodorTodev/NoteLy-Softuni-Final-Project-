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
    public static class GenresSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/Genres.json");
            var seedData = JsonConvert.DeserializeObject<GenresSeedHelper>(jsonData);

            if (seedData != null && seedData.Genres != null)
            {
                modelBuilder.Entity<Genre>().HasData(seedData.Genres);
            }
        }
    }
}
