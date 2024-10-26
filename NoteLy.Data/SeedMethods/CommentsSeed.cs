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
    public static class CommentsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText("../NoteLy.Common/JsonSeedFiles/Comments.json");
            var seedData = JsonConvert.DeserializeObject<CommentsSeedHelper>(jsonData);

            if (seedData != null && seedData.Comments != null)
            {
                modelBuilder.Entity<Comment>().HasData(seedData.Comments);
            }
        }
    }
}
