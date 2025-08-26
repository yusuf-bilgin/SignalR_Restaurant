using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR_Restaurant.EntityLayer.Enums;

namespace SignalR_Restaurant.DtoLayer.Category
{
    public class ResultDto
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public StatusType Status { get; set; }
    }
}
