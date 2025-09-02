using SignalR_Restaurant.EntityLayer.Enums;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public StatusType Status { get; set; }

        public List<Product> Products { get; set; }
    }
}