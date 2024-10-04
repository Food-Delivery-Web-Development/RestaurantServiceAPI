namespace Restaurant.Service.Dtos.Concretes.Restaurant;

using Domain.Concretes;
using Interfaces;

public class UpdateRestaurantDto : IUpdateDto<Restaurant>
{
    public string? Name { get; init; }
    public string? Branch { get; init; }
    public string? LogoUrl { get; init; }

    public Restaurant FromEntity(Restaurant entity)
    {
        entity.Name = Name ?? entity.Name;
        entity.Branch = Branch ?? entity.Branch;
        entity.LogoUrl = LogoUrl ?? entity.LogoUrl;

        return entity;
    }
}
