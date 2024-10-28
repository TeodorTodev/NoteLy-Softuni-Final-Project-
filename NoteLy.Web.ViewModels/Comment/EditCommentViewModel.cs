using System.ComponentModel.DataAnnotations;
using static NoteLy.Common.EntityValidationConstants.Comment;
using static NoteLy.Common.EntityValidationMessages.Comment;

namespace NoteLy.Web.ViewModels.Comment
{
    public class EditCommentViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = ContentRequiredMessage)]
        [MaxLength(CommentMaxLength, ErrorMessage = ContentMaxLengthMessage)]
        public string Text { get; set; } = null!;
    }
}
