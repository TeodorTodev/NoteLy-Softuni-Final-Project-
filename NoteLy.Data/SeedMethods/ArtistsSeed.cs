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
    public static  class ArtistsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/Artists.json");
            var seedData = JsonConvert.DeserializeObject<ArtistsSeedHelper>(jsonData);

            if (seedData != null && seedData.Artists != null)
            {
                modelBuilder.Entity<Artist>().HasData(seedData.Artists);
            }
        }
    }
}
