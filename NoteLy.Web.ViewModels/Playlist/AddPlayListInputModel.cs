using System.ComponentModel.DataAnnotations;
using static NoteLy.Common.EntityValidationConstants.PlayList;
using static NoteLy.Common.EntityValidationMessages.PlayList;

namespace NoteLy.Web.ViewModels.Playlist
{
    public class AddPlayListInputModel
	{
		[Required(ErrorMessage = NameRequiredMessage)]
        [StringLength(PlayListNameMaxLength, ErrorMessage = NameRangeMessage, MinimumLength = PlayListNameMinLength)]
        public string Name { get; set; } = null!;
	}
}
