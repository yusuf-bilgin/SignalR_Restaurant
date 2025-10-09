using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int ProductId { get; set; } // Sipariş edilen ürünün ID'si - Foreign Key - Product tablosuna referans
        public Product Product { get; set; }

        public int Quantity { get; set; } // Ürün adedi
        public decimal UnitPrice { get; set; } // Ürün birim fiyatı
        public decimal TotalPrice { get; set; } // Toplam fiyat (UnitPrice * Quantity)

        public int OrderId { get; set; } // Hangi siparişe ait olduğunu belirtir - Foreign Key - Order tablosuna referans
        public Order Order { get; set; } // Navigation property - Order tablosuyla ilişki
    }
}
