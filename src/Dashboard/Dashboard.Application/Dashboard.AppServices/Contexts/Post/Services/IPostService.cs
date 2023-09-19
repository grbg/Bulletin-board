using Dashboard.Contracts;
using Dashboard.Dashboard.Contracts.Posts;

namespace Dashboard.Application.AppServices.Contexts.Post.Services;

/// <summary>
/// Сервис работы с объявлениями.
/// </summary>
public interface IPostService
{
    /// <summary>
    /// Возвращает объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PostDto"/></returns>
    Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Возвращает объявления согласно параметрам страницы
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns></returns>
    Task<PostDto> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0);

    /// <summary>
    /// Создаёт объявление по модели.
    /// </summary>
    /// <param name="model">Модель объявления.</param>
    /// <param name="cancellationToken">Токен отмены.</param>
    /// <returns>Идентификатор созданной сущности.</returns>
    Task<Guid> CreateAsync(CreatePostDto model, CancellationToken cancellationToken);

    /// <summary>
    /// Изменение объявления.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns></returns>
    Task UpdateAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Удаляет объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken);
}