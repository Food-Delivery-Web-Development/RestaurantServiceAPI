namespace Restaurant.Service.Dtos.Concretes.Product;

using Domain.Concretes;
using Interfaces;

public class CreateProductDto : ICreateDto<Product>
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public required decimal Price { get; init; }
    public required string ImageUrl { get; init; }
    public required Guid RestaurantId { get; init; }

    public Product ToEntity()
    {
        return new Product
        {
            Name = Name,
            Description = Description,
            Price = Price,
            ImageUrl = ImageUrl,
            RestaurantId = RestaurantId,
        };
    }
}
