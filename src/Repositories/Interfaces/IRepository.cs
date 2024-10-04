namespace Restaurant.Service.Repositories.Interfaces;

using Domain.Interfaces;

public interface IRepository<T> : IDisposable
    where T : class, IEntity, new()
{
    Task<IEnumerable<T>> GetAll();
    Task<T?> Create(T entity);
    Task<T?> GetById(Guid id);
    Task<T?> Update(T entity);
    Task<bool> Delete(T entity);
    Task<bool> Exists(Guid id);
}
