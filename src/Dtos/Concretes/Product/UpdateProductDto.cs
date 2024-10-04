namespace Restaurant.Service.Dtos.Concretes.Product;

using Domain.Concretes;
using Interfaces;

public class UpdateProductDto : IUpdateDto<Product>
{
    public string? Name { get; init; }
    public string? Description { get; init; }
    public decimal? Price { get; init; }
    public Guid? RestaurantId { get; init; }

    public Product FromEntity(Product entity)
    {
        entity.Name = Name ?? entity.Name;
        entity.Description = Description ?? entity.Description;
        entity.Price = Price ?? entity.Price;
        entity.RestaurantId = RestaurantId ?? entity.RestaurantId;

        return entity;
    }
}
