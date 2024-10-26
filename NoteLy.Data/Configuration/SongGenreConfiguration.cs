using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Data.Configuration
{
    public class SongGenreConfiguration : IEntityTypeConfiguration<SongGenre>
    {
        public void Configure(EntityTypeBuilder<SongGenre> builder)
        {
            builder.HasKey(sg => new { sg.SongId, sg.GenreId});
        }
    }
}
