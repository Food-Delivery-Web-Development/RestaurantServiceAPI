namespace Restaurant.Service.Dtos.Concretes.Address;

using Domain.Concretes;
using Interfaces;

public class UpdateAddressDto : IUpdateDto<Address>
{
    public string? Street { get; init; }
    public string? City { get; init; }
    public string? Country { get; init; }
    public Guid? RestaurantId { get; init; }

    public Address FromEntity(Address entity)
    {
        entity.Street = Street ?? entity.Street;
        entity.City = City ?? entity.City;
        entity.Country = Country ?? entity.Country;
        entity.RestaurantId = RestaurantId ?? entity.RestaurantId;

        return entity;
    }
}
