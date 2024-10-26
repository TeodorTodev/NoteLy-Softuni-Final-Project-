using Notely.Data.Models;
using System.ComponentModel.DataAnnotations;
using static NoteLy.Common.EntityValidationConstants.PlayList;
namespace NoteLy.Data.Models
{
    public class PlayList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PlayListNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public ICollection<Song> Songs { get; set; } = new HashSet<Song>();
    }
}
