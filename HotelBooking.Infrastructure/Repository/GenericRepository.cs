using HotelBooking.Domain.Common;
using HotelBooking.Domain.Interface;
using HotelBooking.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Infrastructure.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
             return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync();
        }
    }
}
