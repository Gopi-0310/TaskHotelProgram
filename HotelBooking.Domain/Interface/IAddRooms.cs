using HotelBooking.Domain.Model;

namespace HotelBooking.Domain.Interface
{
    public interface IAddRooms : IGeneric<AddRooms>
    {
        Task UpdateAsync(AddRooms addRooms);
    }
}
