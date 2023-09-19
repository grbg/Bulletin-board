using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.AppServices.Contexts.Post.Repositories;
using Dashboard.Dashboard.Contracts.Posts;
using Dashboard.DashboardDomain.Posts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с объявлениями.
/// </summary>
[ApiController]
[Route("post")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;

    /// <summary>
    /// Инициализует экземпляр <see cref="PostController"/>
    /// </summary>
    /// <param name="postService">Сервис работы с объявлениями.</param>
    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    /// <summary>
    /// Возвращает объявления по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример: 
    /// curl: -XGET http://host:port/post/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PostDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(PostDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public IActionResult GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = _postService.GetByIdAsync(id, cancellationToken);
        if (result == null)
        {
            return NotFound("Объявление не найдено");
        }
        return Ok(result);
    }

    /// <summary>
    /// Возвращает  постраничные объявления.
    /// </summary>
    /// Пример:
    /// curl: -XGET http://host:port/post/get-all-paged
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция объявлений <see cref="PostDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<ActionResult<Post>> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        var post = await _postService.GetAllAsync(cancellationToken, pageSize, pageIndex);
        return Ok(post);
    }

    /// <summary>
    /// Создаёт объявление.
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreatePostDto dto, CancellationToken cancellationToken)
    {
        var modelId = await _postService.CreateAsync(dto, cancellationToken);
        return Created(nameof(CreateAsync) ,modelId);
    }

    /// <summary>
    /// Редактирует объявление.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(Guid id, PostDto dto, CancellationToken cancellationToken)
    {
        var post = await _postService.GetByIdAsync(id,  cancellationToken);
        if (post == null)
        {
            return NotFound();
        }
        await _postService.UpdateAsync(id, cancellationToken);

        return NoContent();
    }

    /// <summary>
    /// Удаляет объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var post = await _postService.DeleteAsync(id, cancellationToken);
        if (post == null)
        {
            return NotFound();
        }
        return NoContent();
    }
}