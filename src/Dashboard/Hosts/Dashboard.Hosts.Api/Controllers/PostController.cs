using Dashboard.Dashboard.Contracts.Posts;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// ���������� ��� ������ � ������������.
/// </summary>
public class PostController : ControllerBase
{
    /// <summary>
    /// ���������� ���������� �� ��������������.
    /// </summary>
    /// <param name="id">������������� ����������.</param>
    /// <param name="cancellationToken">������ ��������.</param>
    /// <returns>������ ���������� <see cref="PostDto"/></returns>
    [HttpGet("get-by-id")]
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