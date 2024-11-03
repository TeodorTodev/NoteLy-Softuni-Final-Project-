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
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasKey(ars => new { ars.SongId, ars.ArtistId });

            builder
                .HasOne(ars => ars.Artist)
                .WithMany(a => a.ArtistSongs)
                .HasForeignKey(ars => ars.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ars => ars.Song)
                .WithMany(s => s.Artists)
                .HasForeignKey(ars => ars.SongId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
