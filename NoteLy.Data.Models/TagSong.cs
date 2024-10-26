using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NoteLy.Common.EntityValidationConstants;

namespace Notely.Data.Models
{
    [PrimaryKey(nameof(SongId), nameof(TagId))]
    public class TagSong
    {
        public int SongId { get; set; }

        [ForeignKey(nameof(SongId))]
        public Song Song { get; set; } = null!;

        public int TagId { get; set; }

        [ForeignKey(nameof(TagId))]
        public Tag Tag { get; set; } = null!;
    }
}
