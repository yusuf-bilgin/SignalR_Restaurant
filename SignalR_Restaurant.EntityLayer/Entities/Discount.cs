namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public int Ratio { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
