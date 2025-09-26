using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.WebUI.Dtos.DiscountDtos
{
    public class ResultDiscountDto
    {
        public int DiscountId { get; set; }
        public int Ratio { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
