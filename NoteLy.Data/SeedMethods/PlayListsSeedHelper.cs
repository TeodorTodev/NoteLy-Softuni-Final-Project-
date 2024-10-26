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
    public class PlayListsSeedHelper
    {
        public PlayList[] PlayLists { get; set; } = null!;
    }
}
