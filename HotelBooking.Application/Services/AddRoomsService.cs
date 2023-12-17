using AutoMapper;
using HotelBooking.Application.Interface;
using HotelBooking.Application.RequestAndResponseType;
using HotelBooking.Domain.Interface;
using HotelBooking.Domain.Model;


namespace HotelBooking.Application.Services
{
    public class AddRoomsService : IAddRoomService
    {
        private readonly IAddRooms _addRoom;
        private readonly IMapper _map;
        public AddRoomsService(IAddRooms room, IMapper mapper)
        {
            _addRoom = room;
            _map = mapper;
        }

        public async Task<CreateRoomsDto> CreateAsync(CreateRoomsDto dto)
        {
            var mapRoom = _map.Map<AddRooms>(dto);
            await _addRoom.CreateAsync(mapRoom);
            return dto;
        }

        public async Task DeleteAsync(int id)
        {
            var exitsData = await _addRoom.GetByIdAsync(id);
            await _addRoom.DeleteAsync(exitsData);
        }

        public async Task<IEnumerable<AddRoomsDto>> GetAllAsync()
        {
            var roomList = await _addRoom.GetAllAsync();
            return _map.Map<IEnumerable<AddRoomsDto>>(roomList);

        }

        public async Task<AddRoomsDto> GetByIdAsync(int id)
        {
            var room = await _addRoom.GetByIdAsync(id);
            return _map.Map<AddRoomsDto>(room);
        }

        public async Task UpdateAsync(AddRoomsDto dto)
        {
            var exitsData = await _addRoom.GetByIdAsync(dto.Id);
            if (exitsData != null)
            {
                var mapRoom = _map.Map<AddRooms>(dto);
                await _addRoom.UpdateAsync(mapRoom);
            }
        }
    }
}
