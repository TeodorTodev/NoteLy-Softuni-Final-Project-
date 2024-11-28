using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data.Configuration;
using NoteLy.Data.Models;

namespace NoteLy.Data
{
    public class NoteLyDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public NoteLyDbContext()
        {
            
        }

        public NoteLyDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Artist> Artists { get; set; } = null!;
        public virtual DbSet<ArtistSong> ArtistSongs { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<PlayList> PlayLists { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ArtistSongConfiguration());
            builder.ApplyConfiguration(new SongConfiguration());
            builder.ApplyConfiguration(new PlayListConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
        }
    }
}
