namespace Restaurant.Service.Repositories.Concretes;

using Bases;
using Context;
using Domain.Concretes;
using Microsoft.EntityFrameworkCore;

public class ProductRepository(PostgresContext context) : BaseRepository<Product>(context)
{
    protected override IQueryable<Product> GetQueryable()
    {
        return Context.Set<Product>();
    }
}
