using RentCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Repositories
{
    public class CarInspectionRepository<TDbContext> : Repository<TDbContext, CarInspection> where TDbContext : DbContext
    {
        public CarInspectionRepository(TDbContext context) : base(context)
        {
        }
    }
}
