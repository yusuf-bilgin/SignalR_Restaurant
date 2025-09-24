using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.WebUI.Dtos.AboutDtos
{
    public class CreateAboutDto
    {
        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }

        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
