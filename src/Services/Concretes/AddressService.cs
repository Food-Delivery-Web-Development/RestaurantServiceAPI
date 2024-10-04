namespace Restaurant.Service.Services.Concretes;

using Bases;
using Domain.Concretes;
using Repositories.Interfaces;

public class AddressService(IRepository<Address> repository) : BaseService<Address>(repository) { }
