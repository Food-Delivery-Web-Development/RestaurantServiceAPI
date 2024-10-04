namespace Restaurant.Service.Services.Concretes;

using Bases;
using Domain.Concretes;
using Repositories.Interfaces;

public class RestaurantService(IRepository<Restaurant> repository)
    : BaseService<Restaurant>(repository) { }
