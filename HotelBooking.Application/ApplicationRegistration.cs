using HotelBooking.Application.Interface;
using HotelBooking.Application.Mapper;
using HotelBooking.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBooking.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(MappingProfile));
            service.AddScoped<IAddRoomService, AddRoomsService>();
            return service;
        }
    }
}
