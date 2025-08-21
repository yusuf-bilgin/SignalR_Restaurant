using SignalRApi.Enums;

namespace SignalRApi.DAL.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public StatusType Status{ get; set; }
    }
}