using AutoMapper;
using SignalR_Restaurant.DtoLayer.SocialMedia;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultDto>().ReverseMap();
            CreateMap<SocialMedia, CreateDto>().ReverseMap();
            CreateMap<SocialMedia, GetDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateDto>().ReverseMap();
        }
    }
}
