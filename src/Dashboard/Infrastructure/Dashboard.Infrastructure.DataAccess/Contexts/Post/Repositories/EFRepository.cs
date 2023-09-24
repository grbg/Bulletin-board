using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Dashboard.Contracts.Posts;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories
{
    public class EFRepository : IPostRepository
    {
        private readonly DataContext _dataContext;

        public EFRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<Guid> CreateAsync(DashboardDomain.Posts.Post model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
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
    }
}
