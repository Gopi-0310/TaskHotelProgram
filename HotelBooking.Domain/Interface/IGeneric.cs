using HotelBooking.Domain.Common;

namespace HotelBooking.Domain.Interface
{
    public interface IGeneric<T> where T :BaseModel
    {
        Task<T> CreateAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task DeleteAsync(T entity);
    }
}
