using AutoMapper;
using SignalR_Restaurant.DtoLayer.Discount;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDto>().ReverseMap();
            CreateMap<Discount, CreateDto>().ReverseMap();
            CreateMap<Discount, GetDto>().ReverseMap();
            CreateMap<Discount, UpdateDto>().ReverseMap();
        }
    }
}
