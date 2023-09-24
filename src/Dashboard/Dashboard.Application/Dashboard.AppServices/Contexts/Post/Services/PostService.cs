using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;
using Dashboard.Dashboard.Contracts.Posts;
using System.ComponentModel;
using System.Reflection;

namespace Dashboard.Application.AppServices.Contexts.Post.Services;

/// <inheritdoc />
public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PostService"/>
    /// </summary>
    /// <param name="postRepository">Репозиторий для работы с объявлениями.</param>
    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    /// <inheritdoc />
    public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _postRepository.GetByIdAsync(id, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(CreatePostDto model, CancellationToken cancellationToken)
    {
            var post = new DashboardDomain.Posts.Post();
            {
                post.Description = model.Description;
                post.Title = model.Title;
                post.CategoryId = model.CategoryId;
                post.Author = model.Author;
                post.TagNames = model.TagNames;
            };
            return _postRepository.CreateAsync(post, cancellationToken);
    }

    public Task<PostDto> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Guid> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}