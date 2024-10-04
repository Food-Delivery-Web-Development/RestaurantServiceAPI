namespace Restaurant.Service.Controllers.Concretes;

using Bases;
using Domain.Concretes;
using Dtos.Concretes.Product;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

[Route("api/products")]
public class ProductController(IService<Product> service)
    : BaseController<Product, CreateProductDto, UpdateProductDto>(service) { }
