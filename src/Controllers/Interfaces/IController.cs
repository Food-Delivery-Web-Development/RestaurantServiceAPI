namespace Restaurant.Service.Controllers.Interfaces;

using Domain.Interfaces;
using Dtos.Interfaces;
using Microsoft.AspNetCore.Mvc;

public interface IController<TEntity, TCreateDto, TUpdateDto>
    where TEntity : class, IEntity, new()
    where TCreateDto : class, ICreateDto<TEntity>
    where TUpdateDto : class, IUpdateDto<TEntity>
{
    Task<IActionResult> Create(TCreateDto request);

    Task<IActionResult> GetAll();

    Task<IActionResult> GetById(Guid id);

    Task<IActionResult> Update(Guid id, TUpdateDto request);

    Task<IActionResult> Delete(Guid id);
}
