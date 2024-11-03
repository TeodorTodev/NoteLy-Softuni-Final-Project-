namespace NoteLy.Web.ViewModels.Playlist
{
    public class CollectionCardViewModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Guid ApplicationUserId { get; set; }
    }
}
