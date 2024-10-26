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
    public static class TagSongsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/TagSongs.json");
            var seedData = JsonConvert.DeserializeObject<TagSongsSeedHelper>(jsonData);

            if (seedData != null && seedData.TagSongs != null)
            {
                modelBuilder.Entity<TagSong>().HasData(seedData.TagSongs);
            }
        }
    }
}
