using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.DtoLayer.Category
{
    public class GetCategoryDto
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public bool Status { get; set; }
    }
}
