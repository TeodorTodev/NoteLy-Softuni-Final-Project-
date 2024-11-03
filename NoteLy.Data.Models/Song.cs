using NoteLy.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static NoteLy.Common.EntityValidationConstants.Song;

namespace Notely.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(SongNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public string FilePath { get; set; } = null!;

        [Required]
        public int PlayListId { get; set; }

        [ForeignKey(nameof(PlayListId))]
        public PlayList PlayList { get; set; } = null!;

        [Required]
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        public ICollection<ArtistSong> Artists { get; set; } = new HashSet<ArtistSong>();

        public ICollection<Comment>? Comments { get; set; } = new HashSet<Comment>();

        public ICollection<TagSong>? TagSongs { get; set; } = new HashSet<TagSong>();

        [Required]
        public ICollection<SongGenre> SongGenres { get; set; } = new HashSet<SongGenre>();
    }
}
