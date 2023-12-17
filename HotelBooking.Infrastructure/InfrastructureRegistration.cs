using HotelBooking.Application.Interface;
using HotelBooking.Application.Services;
using HotelBooking.Domain.Interface;
using HotelBooking.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBooking.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection service)
        {
            service.AddScoped(typeof(IGeneric<>), typeof(GenericRepository<>));
            service.AddScoped<IAddRooms, AddRoomsRepository>();
            service.AddScoped<IAuthService, AuthServices>();
            return service;
        }
    }
}
