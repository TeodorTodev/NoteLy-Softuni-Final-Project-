using NoteLy.Data.Models;
using NoteLy.Web.ViewModels.Comment;
using NoteLy.Web.ViewModels.Playlist;
using NoteLy.Web.ViewModels.Song;

namespace NoteLy.Services.Data.Interfaces
{
    public interface IHomeService
    {
        Task<IEnumerable<CollectionCardViewModel>> IndexGetAllPlaylists();

        Task<IEnumerable<SongCardViewModel>> GetAllPlaylistsWithSongsAndArtists(int id, Guid currentUserId);

        Task<IEnumerable<CommentCardViewModel>> GetCommentsBySongId(int id, Guid currentUserId);
    }
}
