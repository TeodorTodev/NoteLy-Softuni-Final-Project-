using System.ComponentModel.DataAnnotations;
using static NoteLy.Common.EntityValidationConstants.Song;
using static NoteLy.Common.EntityValidationMessages.Song;

namespace NoteLy.Web.ViewModels.Song
{
    public class EditSongViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = NameRequiredMessage)]
        [MaxLength(SongNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = DurationRequiredMessage)]
        public TimeSpan Duration { get; set; }

        [Required(ErrorMessage = UrlRequiredMessage)]
        public string FilePath { get; set; } = null!;

        [Required(ErrorMessage = ArtistsRequiredMessage)]
        public string ArtistNames { get; set; } = null!;
    }
}
