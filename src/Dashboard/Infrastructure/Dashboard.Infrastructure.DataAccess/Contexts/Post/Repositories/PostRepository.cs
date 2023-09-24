using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Dashboard.Contracts.Posts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

/// <inheritdoc cref="IPostRepository"/>
public class PostRepository : IPostRepository
{

    public async Task<Guid> CreateAsync(DashboardDomain.Posts.Post model, CancellationToken cancellationToken)
    {
        return model.PostId;
    }

    public Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, DashboardDomain.Posts.Post model, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


    /*private readonly List<DashboardDomain.Posts.Post> _posts = new();

    /// <inheritdoc />
    public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new PostDto
        {
            PostId = Guid.NewGuid(),
            Title = "Тестовое объявление",
            Description = "Описание: ",
            CategoryName = "Книги",
            Author = "Иванов И.И.",
            TagNames = new[]{ "фентези", "приключение" },
            Price = 1000.00M,
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(DashboardDomain.Posts.Post model, CancellationToken cancellationToken)
    {
        model.PostId = Guid.NewGuid();
        _posts.Add(model);
        return Task.Run(() => model.PostId);
    }*/
}
