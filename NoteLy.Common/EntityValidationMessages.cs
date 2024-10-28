using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Common
{
    public static class EntityValidationMessages
    {
        public static class PlayList
        {
			public const string NameRequiredMessage = "Playlist name is required.";
			public const string NameRangeMessage = "The name must be between 3 and 30 characters";
		}
        public static class Song
        {
            public const string NameRequiredMessage = "Song name is required.";
            public const string DurationRequiredMessage = "Song duration is required.";
            public const string UrlRequiredMessage = "YouTube URL is required.";
            public const string PlaylistRequiredMessage = "Playlist is rquired";
            public const string ArtistsRequiredMessage = "Enter at least 1 artist";
        }

        public static class Comment 
        {
            public const string ContentRequiredMessage = "Comment content is required.";
            public const string ContentMaxLengthMessage = "Exceeding maximum length of 255 characters.";
        }
    }
}
