using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.AppServices.Contexts.Post.Repositories;
using Dashboard.Dashboard.Contracts.Posts;
using Dashboard.DashboardDomain.Posts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// ���������� ��� ������ � ������������.
/// </summary>
[ApiController]
[Route("post")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;

    /// <summary>
    /// ������������ ��������� <see cref="PostController"/>
    /// </summary>
    /// <param name="postService">������ ������ � ������������.</param>
    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    /// <summary>
    /// ���������� ���������� �� ��������������.
    /// </summary>
    /// <remarks>
    /// ������: 
    /// curl: -XGET http://host:port/post/get-by-id
    /// </remarks>
    /// <param name="id">������������� ����������.</param>
    /// <param name="cancellationToken">������ ��������.</param>
    /// <returns>������ ���������� <see cref="PostDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(PostDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public IActionResult GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = _postService.GetByIdAsync(id, cancellationToken);
        if (result == null)
        {
            return NotFound("���������� �� �������");
        }
        return Ok(result);
    }

    /// <summary>
    /// ����������  ������������ ����������.
    /// </summary>
    /// ������:
    /// curl: -XGET http://host:port/post/get-all-paged
    /// <param name="cancellationToken">������ ��������.</param>
    /// <param name="pageSize">������ ��������.</param>
    /// <param name="pageIndex">����� ��������.</param>
    /// <returns>��������� ���������� <see cref="PostDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<ActionResult<Post>> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        var post = await _postService.GetAllAsync(cancellationToken, pageSize, pageIndex);
        return Ok(post);
    }

    /// <summary>
    /// ������ ����������.
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
    /// ����������� ����������.
    /// </summary>
    /// <param name="cancellationToken">������ ��������.</param>
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
    /// ������� ���������� �� ��������������.
    /// </summary>
    /// <param name="id">������������� ����������.</param>
    /// <param name="cancellationToken">������ ��������.</param>
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