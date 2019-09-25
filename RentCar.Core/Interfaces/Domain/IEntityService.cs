using RentCar.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Interfaces.Domain
{
    public interface IEntityService<TEntity> where TEntity : Entity
    {
            Task<TEntity> AddAsync(TEntity entity);
            Task AddAsync(IEnumerable<TEntity> entitys);
            Task<TEntity> UpdateAsync( TEntity entity);
            Task UpdateRangeAsync(IEnumerable<TEntity> entitys);
            Task<TEntity> DeleteAsync(int id);
            Task DeleteRangeAsync(IEnumerable<TEntity> entitys);
            Task<TEntity> GetByIdAsync(int id);
            IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
