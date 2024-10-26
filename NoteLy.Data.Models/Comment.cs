using NoteLy.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static NoteLy.Common.EntityValidationConstants.Comment;

namespace Notely.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(CommentMaxLength)]
        public string? Text { get; set; }

        [Required]
        public int SongId { get; set; }

        [ForeignKey(nameof(SongId))]
        public Song Song { get; set; } = null!;

        [Required]
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
