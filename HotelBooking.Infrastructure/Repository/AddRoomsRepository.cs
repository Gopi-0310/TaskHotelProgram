using HotelBooking.Domain.Interface;
using HotelBooking.Domain.Model;
using HotelBooking.Infrastructure.DB;

namespace HotelBooking.Infrastructure.Repository
{
    public class AddRoomsRepository : GenericRepository<AddRooms>, IAddRooms
    {
        private readonly ApplicationDbContext _context;
        public AddRoomsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task UpdateAsync(AddRooms addRooms)
        {

            _context.AddRooms.Update(addRooms);
            await _context.SaveChangesAsync();
        }
    }
}
