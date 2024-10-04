namespace Restaurant.Service.Repositories.Concretes;

using Bases;
using Context;
using Domain.Concretes;
using Microsoft.EntityFrameworkCore;

public class RestaurantRepository(PostgresContext context) : BaseRepository<Restaurant>(context)
{
    protected override IQueryable<Restaurant> GetQueryable()
    {
        return Context.Set<Restaurant>().Include(r => r.Products).Include(r => r.Address);
    }
}
