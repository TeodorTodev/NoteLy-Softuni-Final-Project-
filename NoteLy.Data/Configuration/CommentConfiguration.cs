using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notely.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
            .HasOne(c => c.Song)
            .WithMany(s => s.Comments)
            .HasForeignKey(c => c.SongId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
