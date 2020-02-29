﻿using BussinesLayer.Repository.Contracts;
using DatabaseLayer.Persistence;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BussinesLayer.Repository.Services
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>  where TEntity :class
    {
        private readonly ApplicationDbContext _dbContext;
        public BaseRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
        public async Task<bool> Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> expression) => _dbContext.Set<TEntity>().Where(expression);

        public IQueryable<TEntity> GetAll() => _dbContext.Set<TEntity>().AsQueryable();

        public async Task<TEntity> GetById(Guid id) => await _dbContext.Set<TEntity>().FindAsync(id);

        public async Task<bool> Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}
