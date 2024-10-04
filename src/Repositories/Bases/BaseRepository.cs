namespace Restaurant.Service.Repositories.Bases;

using Context;
using Domain.Interfaces;
using Interfaces;
using Microsoft.EntityFrameworkCore;

public abstract class BaseRepository<T>(PostgresContext context) : IRepository<T>
    where T : class, IEntity, new()
{
    protected readonly PostgresContext Context = context;

    public void Dispose()
    {
        Context?.Dispose();
    }

    protected abstract IQueryable<T> GetQueryable();

    public async Task<IEnumerable<T>> GetAll()
    {
        return await GetQueryable().ToListAsync();
    }

    public async Task<T?> GetById(Guid id)
    {
        return await GetQueryable().FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<T?> Create(T entity)
    {
        var exists = await Exists(entity.Id);

        if (exists)
        {
            return null;
        }

        Context.Set<T>().Add(entity);
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<T?> Update(T entity)
    {
        var exists = await Exists(entity.Id);

        if (!exists)
        {
            return null;
        }

        Context.Set<T>().Update(entity);
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<bool> Delete(T entity)
    {
        var exists = await Exists(entity.Id);

        if (!exists)
        {
            return false;
        }

        Context.Set<T>().Remove(entity);
        await Context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> Exists(Guid id)
    {
        return await Context.Set<T>().AnyAsync(x => x.Id.Equals(id));
    }
}
