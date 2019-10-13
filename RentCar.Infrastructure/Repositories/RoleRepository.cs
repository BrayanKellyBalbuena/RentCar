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
    public class RoleRepository<TDbContext> : Repository<TDbContext, Role> where TDbContext : DbContext
    {
        public RoleRepository(TDbContext context) : base(context)
        {
        }
    }
}
