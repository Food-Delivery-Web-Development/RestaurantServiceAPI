namespace Restaurant.Service.Controllers.Concretes;

using Bases;
using Domain.Concretes;
using Dtos.Concretes.Address;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

[Route("api/addresses")]
public class AddressController(IService<Address> service)
    : BaseController<Address, CreateAddressDto, UpdateAddressDto>(service) { }
