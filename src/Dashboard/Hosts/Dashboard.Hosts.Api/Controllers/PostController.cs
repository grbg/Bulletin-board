using Dashboard.Dashboard.Contracts.Posts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// ���������� ��� ������ � ������������.
/// </summary>
[ApiController]
[Route("{post}")]
public class PostController : ControllerBase
{
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
    [ProducesResponseType(typeof(PostDto),(int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }

    /// <summary>
    /// ����������  ������������ ����������.
    /// </summary>
    /// <param name="cancellationToken">������ ��������.</param>
    /// <param name="pageSize">������ ��������.</param>
    /// <param name="pageIndex">����� ��������.</param>
    /// <returns>��������� ���������� <see cref="PostDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }

    /// <summary>
    /// ������� ����������.
    /// </summary>
    /// <param name="cancellationToken">������ ��������.</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(PostDto dto, CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }

    /// <summary>
    /// ����������� ����������.
    /// </summary>
    /// <param name="cancellationToken">������ ��������.</param>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(PostDto dto, CancellationToken cancellationToken)
    {
        return Ok();
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
        return Ok();
    }
}