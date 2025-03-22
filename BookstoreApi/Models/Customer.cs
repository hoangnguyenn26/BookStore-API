namespace BookstoreApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public List<Cart> CartItems { get; set; } = new List<Cart>();
    }
}