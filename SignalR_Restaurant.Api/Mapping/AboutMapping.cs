using AutoMapper;
using SignalR_Restaurant.DtoLayer.About;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultDto>().ReverseMap();
            CreateMap<About, CreateDto>().ReverseMap();
            CreateMap<About, GetDto>().ReverseMap();
            CreateMap<About, UpdateDto>().ReverseMap();
        }
    }
}
