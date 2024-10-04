namespace Restaurant.Service.Repositories.Concretes;

using Bases;
using Context;
using Domain.Concretes;

public class RestaurantRepository(PostgresContext context) : BaseRepository<Restaurant>(context) { }
