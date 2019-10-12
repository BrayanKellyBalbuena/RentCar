
using RentCar.Core.Abstractions;
using RentCar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Abstractions
{
    public abstract class Repository<TContext, TEntity> : IDisposable, IRepository<TEntity> where TEntity : Entity where TContext : DbContext
    {
        private bool _save = true;
        private readonly TContext _context;
        private readonly DbSet<TEntity> _set;

        public Repository(TContext context)
        {
            _context = context;
            _context.Database.Log = Console.Write;
            _set = _context.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            entity.State = true;
            _set.Add(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            RestrictSave();
            foreach (var entity in entities) await AddAsync(entity);
            EnableSave();
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            RestrictSave();
            foreach (var entity in entities) await UpdateAsync(entity);
            EnableSave();
            await SaveChangesAsync();
        }

        public virtual async Task<TEntity> DeleteAsync(TEntity entity)
        {
            entity.State = false;

            await SaveChangesAsync();

            return entity;
        }

        public virtual async Task<TEntity> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null) entity = await DeleteAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            var dto = await _set.FirstOrDefaultAsync(e => e.Id.Equals(id) & e.State);

            return dto;
        }

        public virtual Task<TEntity> GetByFilterAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null) return _set.FirstOrDefaultAsync();

            return _set.FirstOrDefaultAsync(filter);
        }

        public virtual IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = _set;

            if (filter != null)
            {
                query = query.Where(filter);
             }
            if (orderBy != null)
            {
                query = orderBy(query);
             };

            return query;
        }

        public virtual async Task<int> SaveChangesAsync()
        {
            if (_save) return await _context.SaveChangesAsync();
            return 0;
        }

        public virtual void RestrictSave() { _save = false; }
        public virtual void EnableSave() { _save = true; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
