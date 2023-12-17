using HotelBooking.Application.RequestAndResponseType;

namespace HotelBooking.Application.Interface
{
    public interface IAddRoomService 
    {
        Task<CreateRoomsDto> CreateAsync(CreateRoomsDto dto);
        Task<IEnumerable<AddRoomsDto>> GetAllAsync();
        Task<AddRoomsDto> GetByIdAsync(int id);
        Task UpdateAsync(AddRoomsDto dto);
        Task DeleteAsync(int id);
    }
}
