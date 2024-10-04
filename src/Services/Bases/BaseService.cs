namespace Restaurant.Service.Services.Bases;

using Domain.Interfaces;
using Interfaces;
using Repositories.Interfaces;

public class BaseService<T>(IRepository<T> repository) : IService<T>
    where T : class, IEntity, new()
{
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await repository.GetAll();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await repository.GetById(id);
    }

    public async Task<T?> CreateAsync(T entity)
    {
        return await repository.Create(entity);
    }

    public async Task<T?> UpdateAsync(T entity)
    {
        return await repository.Update(entity);
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        return await repository.Delete(entity);
    }
}
