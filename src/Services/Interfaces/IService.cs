namespace Restaurant.Service.Services.Interfaces;

using Domain.Interfaces;

public interface IService<T>
    where T : class, IEntity, new()
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    Task<T?> CreateAsync(T entity);
    Task<T?> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);
}
