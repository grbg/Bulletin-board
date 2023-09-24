using Dashboard.Dashboard.Contracts.Posts;
using Dashboard.DashboardDomain.Posts;

namespace Dashboard.Application.AppServices.Contexts.Post.Repositories;

/// <summary>
/// Репозиторий для работы с объявлениями.
/// </summary>
public interface IPostRepository
{
    /// <summary>
    /// Возвращает объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PostDto"/></returns>
    Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Возвращает объявления в пределах страницы.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns></returns>
    Task<PostDto> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0);

    /// <summary>
    /// Создаёт объявление по модели.
    /// </summary>
    /// <param name="model">Модель обявления.</param>
    /// <param name="cancellationToken">Токен отмены.</param>
    /// <returns>Идентификатор созданной сущности.</returns>
    Task<Guid> CreateAsync(DashboardDomain.Posts.Post model, CancellationToken cancellationToken);

    /// <summary>
    /// Редактирует объявление.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="model">Модель объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns></returns>
    Task UpdateAsync(Guid id, DashboardDomain.Posts.Post model, CancellationToken cancellationToken);

    /// <summary>
    /// Удаляет объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns></returns>
    Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken);

}