using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    // Basket entity representing a shopping basket.
    // Masalar ile sepetin eslesmesi saglanacak.
    public class Basket
    {
        public int BasketId { get; set; }
        public decimal TotalPrice { get; set; }

        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public required Product Product { get; set; }    

        public int RestaurantTableId { get; set; }
        public required RestaurantTable RestaurantTable { get; set; }
    }
}
