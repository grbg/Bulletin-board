﻿using Dashboard.AppServices.Contexts.Post.Repositories;
using Dashboard.DashboardDomain.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext DbContext { get;  }
        protected DbSet<TEntity> DbSet { get; }

        public Repository(DbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public IQueryable<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> predicat)
        {
            if (predicat == null)
            {
                throw new ArgumentNullException(nameof(predicat));
            }
            return DbSet.Where(predicat);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            await DbSet.AddAsync(model);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            DbSet.Update(model);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            DbSet.Remove(model);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
           await DbContext.SaveChangesAsync();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}

