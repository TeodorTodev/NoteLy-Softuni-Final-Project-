using System.ComponentModel.DataAnnotations;
using static NoteLy.Common.EntityValidationConstants.PlayList;
using static NoteLy.Common.EntityValidationMessages.PlayList;

namespace NoteLy.Web.ViewModels.Playlist
{
    public class AddPlayListInputModel
	{
		[Required(ErrorMessage = NameRequiredMessage)]
		[MaxLength(PlayListNameMaxLength)]
		public string Name { get; set; } = null!;
	}
}
