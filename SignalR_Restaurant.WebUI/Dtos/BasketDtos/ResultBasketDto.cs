using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.WebUI.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int BasketId { get; set; }
        public decimal TotalPrice { get; set; }

        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public int RestaurantTableId { get; set; }
    }
}
