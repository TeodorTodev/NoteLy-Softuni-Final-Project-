using Notely.Data.Models;

namespace NoteLy.Services.Data.Interfaces
{
    public interface ISongControlsService
    {
        Song? GetSong(int id);
    }
}
