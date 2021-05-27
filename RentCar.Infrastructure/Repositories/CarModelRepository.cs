using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using System.Data.Entity;

namespace RentCar.Infrastructure.Repositories
{
    public class CarModelRepository<TDbContext> : Repository<TDbContext, CarModel> where TDbContext : DbContext
    {
        public CarModelRepository(TDbContext context) : base(context)
        {
        }
    }
}
