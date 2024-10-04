namespace Restaurant.Service.Controllers.Bases;

using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;
using Dtos.Interfaces;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

[ApiController]
public abstract class BaseController<TEntity, TCreateDto, TUpdateDto>(IService<TEntity> service)
    : ControllerBase,
        IController<TEntity, TCreateDto, TUpdateDto>
    where TEntity : class, IEntity, new()
    where TCreateDto : class, ICreateDto<TEntity>
    where TUpdateDto : class, IUpdateDto<TEntity>
{
    protected IService<TEntity> Service { get; } = service;

    [HttpPost]
    public virtual async Task<IActionResult> Create(TCreateDto request)
    {
        TEntity entity = request.ToEntity();

        TEntity? result = await Service.CreateAsync(entity);

        if (result is null)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [HttpGet("{id}")]
    public virtual async Task<IActionResult> GetById([FromRoute] [Required] Guid id)
    {
        TEntity? result = await Service.GetByIdAsync(id);

        return result is not null ? Ok(result) : NotFound();
    }

    [HttpPut("{id}")]
    public virtual async Task<IActionResult> Update(
        [FromRoute] [Required] Guid id,
        TUpdateDto request
    )
    {
        TEntity? searchEntity = await Service.GetByIdAsync(id);

        if (searchEntity is null)
        {
            return NotFound();
        }

        TEntity entity = request.FromEntity(searchEntity);

        TEntity? result = await Service.UpdateAsync(entity);

        if (result is null)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public virtual async Task<IActionResult> Delete([FromRoute] [Required] Guid id)
    {
        TEntity? searchEntity = await Service.GetByIdAsync(id);

        if (searchEntity is null)
        {
            return NotFound();
        }

        bool isDeleted = await Service.DeleteAsync(searchEntity);

        if (!isDeleted)
        {
            return BadRequest();
        }

        return Ok();
    }

    [HttpGet]
    public virtual async Task<IActionResult> GetAll()
    {
        IEnumerable<TEntity> result = await Service.GetAllAsync();

        if (result is null || !result.Any())
        {
            return NotFound();
        }

        return Ok(result);
    }
}
