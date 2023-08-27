using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Dashboard.Contracts.Posts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

public class PostRepository : IPostRepository
{
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
}
