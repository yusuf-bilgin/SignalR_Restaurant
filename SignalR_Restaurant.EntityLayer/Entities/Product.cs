namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool Status{ get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } // Navigation property - OrderDetail tablosuyla ilişki (one-to-many)
        public List<Basket> Baskets { get; set; } // Navigation property - Basket tablosuyla ilişki
    }
}