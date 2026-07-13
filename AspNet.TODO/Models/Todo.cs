namespace AspNet.TODO.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string TaskDue { get; set; } = "Today";
    }
}
