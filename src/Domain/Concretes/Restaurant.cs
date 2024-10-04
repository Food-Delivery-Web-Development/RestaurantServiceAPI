namespace Restaurant.Service.Domain.Concretes;

using Bases;

public class Restaurant : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public Address? Address { get; init; }
    public ICollection<Product> Products { get; init; } = [];
}
