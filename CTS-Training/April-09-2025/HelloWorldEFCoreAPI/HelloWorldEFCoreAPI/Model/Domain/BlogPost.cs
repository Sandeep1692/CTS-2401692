namespace HelloWorldEFCoreAPI.Model.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool IsVisible { get; set; }
    }
}
