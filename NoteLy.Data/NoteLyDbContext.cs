using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Notely.Data.Models;
using NoteLy.Data.Configuration;
using NoteLy.Data.Models;
using NoteLy.Data.SeedMethods;

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
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<PlayList> PlayLists { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;
        public virtual DbSet<SongGenre> SongGenres { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<TagSong> TagSongs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ArtistSongConfiguration());
            builder.ApplyConfiguration(new SongGenreConfiguration());
            builder.ApplyConfiguration(new TagSongConfiguration());
            builder.ApplyConfiguration(new SongConfiguration());
            builder.ApplyConfiguration(new PlayListConfiguration());

            //TagsSeed.Seed(builder);
            //GenresSeed.Seed(builder);
            //ArtistsSeed.Seed(builder);
            //PlayListsSeed.Seed(builder);
            //SongsSeed.Seed(builder);
            //ArtistSongsSeed.Seed(builder);//
            //SongGenresSeed.Seed(builder);//
            //TagSongsSeed.Seed(builder);//
            //CommentsSeed.Seed(builder);//
        }
    }
}
