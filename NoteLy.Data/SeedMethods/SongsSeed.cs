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
    public static class SongsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/Songs.json");
            var seedData = JsonConvert.DeserializeObject<SongsSeedHelper>(jsonData);

            if (seedData != null && seedData.Songs != null)
            {
                modelBuilder.Entity<Song>().HasData(seedData.Songs);
            }
        }
    }
}
