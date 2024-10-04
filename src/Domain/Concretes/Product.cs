namespace Restaurant.Service.Domain.Concretes;

using Bases;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public Guid RestaurantId { get; set; }
}
