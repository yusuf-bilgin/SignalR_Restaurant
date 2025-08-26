using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR_Restaurant.EntityLayer.Enums;

namespace SignalR_Restaurant.DtoLayer.Product
{
    public class UpdateDto
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public StatusType Status { get; set; }
    }
}
