using RentCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Repositories
{
    public class CarRepository<TDbContext> : Repository<TDbContext, Car> where TDbContext : DbContext
    {
        public CarRepository(TDbContext context) : base(context)
        {
        }
    }
}
