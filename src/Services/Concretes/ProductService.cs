namespace Restaurant.Service.Services.Concretes;

using Bases;
using Domain.Concretes;
using Repositories.Interfaces;

public class ProductService(IRepository<Product> repository) : BaseService<Product>(repository) { }
