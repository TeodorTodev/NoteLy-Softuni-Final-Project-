using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Common
{
    public static class EntityValidationConstants
    {
        public static class Album
        {
            public const int AlbumNameMaxLength = 30;
        }

        public static class Artist
        {
            public const int ArtistUserNameMaxLength = 30;
            public const int ArtistFirstNameMaxLength = 30;
            public const int ArtistLastNameMaxLength = 30;
            public const int ArtistPasswordMaxLength = 16;
        }

        public static class Comment
        {
            public const int CommentMaxLength = 255;
        }

        public static class Genre
        {
            public const int GenreNameMaxLength = 20;
        }

        public static class PlayList
        {
            public const int PlayListNameMaxLength = 30;
            public const int PlayListNameMinLength = 3;
        }

        public static class Song
        {
            public const int SongNameMaxLength = 30;
        }

        public static class Tag
        {
            public const int TagNameMaxLength = 20;
        }

        public static class User
        {
            public const int UserUserNameMaxLength = 30;
            public const int UserFirstNameMaxLength = 30;
            public const int UserLastNameMaxLength = 30;
            public const int UserPasswordMaxLength = 16;
        }
    }
}
