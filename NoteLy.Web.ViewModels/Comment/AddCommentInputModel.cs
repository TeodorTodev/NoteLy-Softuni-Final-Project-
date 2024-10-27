using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Web.ViewModels.Comment
{
    public class AddCommentInputModel
    {
        [Required]
        public string Text { get; set; } = null!;

        [Required]
        public string SongName { get; set; } = null!;

        [Required]
        public Guid ApplicationUserId { get; set; }
    }
}
