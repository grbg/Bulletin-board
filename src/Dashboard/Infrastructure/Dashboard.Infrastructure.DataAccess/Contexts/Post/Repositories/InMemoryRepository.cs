using Dashboard.AppServices.Contexts.Post.Repositories;
using Dashboard.DashboardDomain.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories
{
    public class InMemoryRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected List<TEntity> Data { get; set; }

        public InMemoryRepository(IEnumerable<TEntity> data) 
        {
            Data = data.ToList();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(int pageSize)
        {
            return Task.FromResult(Data.AsEnumerable());
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            return Task.FromResult(Data.FirstOrDefault(x => x.PostId == id));
        }
        public Task AddAsync(TEntity model)
        {
            Data.Add(model);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(TEntity model)
        {
            Data.Remove(model);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(TEntity model)
        {
            var existed = Data.FirstOrDefault(x => x.PostId == model.PostId);
            if (existed != null) 
            {
                Data[Data.IndexOf(existed)] = model;
            }
            return Task.CompletedTask;
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
