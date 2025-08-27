using AutoMapper;
using SignalR_Restaurant.DtoLayer.Booking;
using SignalR_Restaurant.EntityLayer.Entities;

namespace SignalR_Restaurant.Api.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultDto>().ReverseMap();
            CreateMap<Booking, CreateDto>().ReverseMap();
            CreateMap<Booking, GetDto>().ReverseMap();
            CreateMap<Booking, UpdateDto>().ReverseMap();
        }
    }
}
