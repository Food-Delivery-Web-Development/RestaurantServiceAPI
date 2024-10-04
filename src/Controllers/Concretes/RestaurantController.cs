namespace Restaurant.Service.Controllers.Concretes;

using Bases;
using Domain.Concretes;
using Dtos.Concretes.Restaurant;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

[Route("api/restaurants")]
public class RestaurantController(IService<Restaurant> service)
    : BaseController<Restaurant, CreateRestaurantDto, UpdateRestaurantDto>(service) { }
