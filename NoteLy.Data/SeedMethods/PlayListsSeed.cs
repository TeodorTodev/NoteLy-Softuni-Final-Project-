using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NoteLy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Data.SeedMethods
{
    public static class PlayListsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/PlayLists.json");
            var seedData = JsonConvert.DeserializeObject<PlayListsSeedHelper>(jsonData);

            if (seedData != null && seedData.PlayLists != null)
            {
                modelBuilder.Entity<PlayList>().HasData(seedData.PlayLists);
            }
        }
    }
}
