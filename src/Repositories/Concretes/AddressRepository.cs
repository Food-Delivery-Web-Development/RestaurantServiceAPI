namespace Restaurant.Service.Repositories.Concretes;

using System.Linq;
using Bases;
using Context;
using Domain.Concretes;
using Microsoft.EntityFrameworkCore;

public class AddressRepository(PostgresContext context) : BaseRepository<Address>(context)
{
    protected override IQueryable<Address> GetQueryable()
    {
        return Context.Set<Address>();
    }
}
