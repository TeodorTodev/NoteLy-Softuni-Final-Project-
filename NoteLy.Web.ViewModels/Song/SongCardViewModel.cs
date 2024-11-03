namespace NoteLy.Web.ViewModels.Song
{
    public class SongCardViewModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string[] Artists { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public bool IsCreator { get; set; }
        public bool IsPlaylistCreator { get; set; }
    }
}
