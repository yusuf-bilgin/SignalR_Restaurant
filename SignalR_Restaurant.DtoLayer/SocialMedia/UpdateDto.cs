using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.DtoLayer.SocialMedia
{
    public class UpdateDto
    {
        public int SocialMediaId { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? UrlIcon { get; set; }
    }
}
