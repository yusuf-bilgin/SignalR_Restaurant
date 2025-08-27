using AutoMapper;
using SignalR_Restaurant.DtoLayer.Contact;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultDto>().ReverseMap();
            CreateMap<Contact, CreateDto>().ReverseMap();
            CreateMap<Contact, GetDto>().ReverseMap();
            CreateMap<Contact, UpdateDto>().ReverseMap();
        }
    }
}
