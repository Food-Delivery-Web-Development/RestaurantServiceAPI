namespace Restaurant.Service.Dtos.Interfaces;

using Domain.Interfaces;

public interface IUpdateDto<T>
    where T : class, IEntity, new()
{
    T FromEntity(T entity);
}
