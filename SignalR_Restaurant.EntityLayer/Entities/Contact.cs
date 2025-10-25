using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.EntityLayer.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? FooterTitle { get; set; }
        public string? FooterDescription { get; set; }
        public string? OpeningDays { get; set; }
        public string? OpenDaysNote { get; set; }
        public string? OpeningHours { get; set; }
    }
}
