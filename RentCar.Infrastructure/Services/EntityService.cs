using RentCar.Core.Abstractions;
using RentCar.Core.Interfaces;
using RentCar.Core.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Abstractions
{
    public abstract class EntityService<TEntity> : IEntityService<TEntity> where TEntity : Entity
    {
        public EntityService(IRepository<TEntity> repository)
        {
            Repository = repository;
        }
        public IRepository<TEntity> Repository { get; protected set; }

        public virtual IQueryable<TEntity> GeTEntity()
        {
            return Repository.GetAll();
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.State = true;
            entity.CreatedDate = DateTime.Now;

            await Repository.AddAsync(entity);
            await Repository.SaveChangesAsync();

            return entity;
        }

        public virtual async Task AddAsync(IEnumerable<TEntity> entities)
        {
            Repository.RestrictSave();

            foreach (var entity in entities) await AddAsync(entity);

            Repository.EnableSave();
            await Repository.SaveChangesAsync();
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entity = await Repository.DeleteAsync(id);
            return entity;
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entitys)
        {
            Repository.RestrictSave();
            var keys = entitys.Select(entity => entity.Id);

            if (keys != null) foreach (var key in keys) await DeleteAsync(key);

            Repository.EnableSave();
            await Repository.SaveChangesAsync();
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(TEntity));

            entity.ModifiedDate = DateTime.Now;

            await Repository.UpdateAsync(entity);

            return entity;
        }

        public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entitys)
        {
            if (entitys == null) throw new ArgumentNullException($" {nameof(TEntity)} is null");

            Repository.RestrictSave();

            foreach (var entity in entitys) await UpdateAsync(entity);

            Repository.EnableSave();
            await Repository.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await Repository.GetByIdAsync(id);

            return entity;
        }

        public virtual IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            if (filter != null)
            {
                return Repository.GetAll(filter).Take(200);
            }

            return Repository.GetAll(x => x.State == true);
        }

        public void Dispose()
        {
            Repository?.Dispose();
            Repository = null;
        }
    }

    internal static class ExpressionTransformer<TFrom, TTo>
    {
        public class Visitor : ExpressionVisitor
        {
            private ParameterExpression _parameter;

            public Visitor(ParameterExpression parameter)
            {
                _parameter = parameter;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return _parameter;
            }
        }

        public static Expression<Func<TTo, bool>> Tranform(Expression<Func<TFrom, bool>> expression)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(TTo));
            Expression body = new Visitor(parameter).Visit(expression.Body);
            return Expression.Lambda<Func<TTo, bool>>(body, parameter);
        }
    }
}
