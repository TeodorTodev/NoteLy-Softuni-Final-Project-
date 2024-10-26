using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NoteLy.Common.EntityValidationConstants.Genre;

namespace Notely.Data.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GenreNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<SongGenre>? SongGenres { get; set; } = new HashSet<SongGenre>();
    }
}
