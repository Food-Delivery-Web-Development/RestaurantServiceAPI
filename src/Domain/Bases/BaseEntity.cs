namespace Restaurant.Service.Domain.Bases;

using Interfaces;

public abstract class BaseEntity : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}
