using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public required string TableNumber { get; set; } // Siparişin verildiği masa numarası
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; } // Siparişin toplam tutarı
        public List<OrderDetail> OrderDetails { get; set; } // Sipariş detayları - Navigation property
    }
}
