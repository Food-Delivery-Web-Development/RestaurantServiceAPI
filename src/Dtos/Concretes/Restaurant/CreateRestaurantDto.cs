namespace Restaurant.Service.Dtos.Concretes.Restaurant;

using Domain.Concretes;
using Interfaces;

public class CreateRestaurantDto : ICreateDto<Restaurant>
{
    public required string Name { get; init; }
    public required string Branch { get; init; }
    public required Guid AddressId { get; init; }

    public Restaurant ToEntity()
    {
        return new Restaurant
        {
            Name = Name,
            Branch = Branch,
            AddressId = AddressId,
        };
    }
}
