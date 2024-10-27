﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Web.ViewModels.Comment
{
    public class EditCommentViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = null!; // add validation
    }
}
