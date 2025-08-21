using System.Reflection.Metadata.Ecma335;
using SignalRApi.Enums;

namespace SignalRApi.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public StatusType Status { get; set; }
    }
}