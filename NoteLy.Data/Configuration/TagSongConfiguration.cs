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
    public class TagSongConfiguration : IEntityTypeConfiguration<TagSong>
    {
        public void Configure(EntityTypeBuilder<TagSong> builder)
        {
            builder.HasKey(tg => new { tg.SongId, tg.TagId});
        }
    }
}
