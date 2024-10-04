namespace Restaurant.Service.Repositories.Concretes;

using Bases;
using Context;
using Domain.Concretes;

public class ProductRepository(PostgresContext context) : BaseRepository<Product>(context) { }
