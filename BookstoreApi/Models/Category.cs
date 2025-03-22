namespace BookstoreApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Book> Books { get; set; } = new List<Book>(); // Navigation property
    }
}