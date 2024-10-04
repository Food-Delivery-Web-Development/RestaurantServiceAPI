namespace Restaurant.Service.Dtos.Concretes.Restaurant;

using Domain.Concretes;
using Interfaces;

public class UpdateRestaurantDto : IUpdateDto<Restaurant>
{
    public string? Name { get; init; }
    public string? Branch { get; init; }
    public Guid? AddressId { get; init; }

    public Restaurant FromEntity(Restaurant entity)
    {
        entity.Name = Name ?? entity.Name;
        entity.Branch = Branch ?? entity.Branch;
        entity.AddressId = AddressId ?? entity.AddressId;

        return entity;
    }
}
