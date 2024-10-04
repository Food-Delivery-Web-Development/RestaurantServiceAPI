namespace Restaurant.Service.Dtos.Interfaces;

using Domain.Interfaces;

public interface ICreateDto<T>
    where T : class, IEntity, new()
{
    T ToEntity();
}
