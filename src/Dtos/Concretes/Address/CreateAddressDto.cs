namespace Restaurant.Service.Dtos.Concretes.Address;

using Domain.Concretes;
using Interfaces;

public class CreateAddressDto : ICreateDto<Address>
{
    public required string Street { get; init; }
    public required string City { get; init; }
    public required string Country { get; init; }
    public required Guid RestaurantId { get; init; }

    public Address ToEntity()
    {
        return new Address
        {
            Street = Street,
            City = City,
            Country = Country,
            RestaurantId = RestaurantId,
        };
    }
}
