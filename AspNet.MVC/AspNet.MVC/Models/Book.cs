namespace AspNet.MVC.Models
{
    public class Book
    {
        public Author? Author { get; set; }
        public string Title { get; set; } = string.Empty;
        public string PublishYear { get; set; } = string.Empty;
    }
}
