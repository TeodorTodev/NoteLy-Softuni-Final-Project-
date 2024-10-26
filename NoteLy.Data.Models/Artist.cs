using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NoteLy.Common.EntityValidationConstants.Artist;

namespace Notely.Data.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ArtistUserNameMaxLength)]
        public string UserName { get; set; } = null!;

        public ICollection<ArtistSong>? ArtistSongs { get; set; } = new HashSet<ArtistSong>();
    }
}
