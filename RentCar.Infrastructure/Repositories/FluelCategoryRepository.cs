using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Repositories
{
   public class FluelCategoryRepository<TDbContext> : Repository<TDbContext, FluelCategory> where TDbContext : DbContext
    {
        public FluelCategoryRepository(TDbContext dbContext) : base(dbContext){ }
    }
}
