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
    public static class TagsSeed
    {
        
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/Tags.json");
            var seedData = JsonConvert.DeserializeObject<TagsSeedHelper>(jsonData);

            if (seedData != null && seedData.Tags != null)
            {
                modelBuilder.Entity<Tag>().HasData(seedData.Tags);
            }
        }
    }

}
