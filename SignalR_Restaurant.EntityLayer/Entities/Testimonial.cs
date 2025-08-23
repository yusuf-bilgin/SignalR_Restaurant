using SignalR_Restaurant.EntityLayer.Enums;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class Testimonial
    {
        public int TestiomonialId { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ImageUrl { get; set; }
        public StatusType Status { get; set; }
    }
}
