using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NoteLy.Common.EntityValidationConstants.Tag;

namespace Notely.Data.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TagNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<TagSong>? TagSongs { get; set; } = new HashSet<TagSong>();
    }
}
