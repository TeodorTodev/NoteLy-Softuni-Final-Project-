using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notely.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Data.Configuration
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
                .HasOne(s => s.PlayList)
                .WithMany(a => a.Songs)
                .HasForeignKey(ars => ars.PlayListId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
