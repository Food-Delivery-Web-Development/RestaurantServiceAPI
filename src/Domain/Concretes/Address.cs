namespace Restaurant.Service.Domain.Concretes;

using Bases;

public class Address : BaseEntity
{
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}
