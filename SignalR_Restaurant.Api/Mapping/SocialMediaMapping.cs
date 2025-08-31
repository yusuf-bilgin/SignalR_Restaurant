using AutoMapper;
using SignalR_Restaurant.DtoLayer.SocialMedia;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
    }
}
