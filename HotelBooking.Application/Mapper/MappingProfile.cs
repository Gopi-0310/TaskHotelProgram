using AutoMapper;
using HotelBooking.Application.RequestAndResponseType;
using HotelBooking.Domain.Model;

namespace HotelBooking.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddRooms, AddRoomsDto>().ReverseMap();
            CreateMap<AddRooms, CreateRoomsDto>().ReverseMap();
        }


    }
}
