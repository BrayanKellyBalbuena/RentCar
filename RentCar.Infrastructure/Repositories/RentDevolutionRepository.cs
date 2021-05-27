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
    public class RentDevolutionRepository<TDbContext> : Repository<TDbContext, RentDevolution> where TDbContext : DbContext
    {
        public RentDevolutionRepository(TDbContext context) : base(context)
        {
        }
    }
}
