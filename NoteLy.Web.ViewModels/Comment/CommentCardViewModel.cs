namespace NoteLy.Web.ViewModels.Comment
{
    public class CommentCardViewModel
    {
        public string Id { get; set; } = null!;

        public string? Text { get; set; }

        public string ApplicationUserName { get; set; } = null!;
        public bool IsCreator { get; set; }
    }
}
