namespace Restaurant.Service.Domain.Concretes;

using Bases;

public class Restaurant : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
    public Guid AddressId { get; set; }
    public Address? Address { get; init; }
    public IEnumerable<Product> Products { get; init; } = [];
}
