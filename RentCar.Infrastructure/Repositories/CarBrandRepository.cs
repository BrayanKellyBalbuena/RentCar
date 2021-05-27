using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using System.Data.Entity;

namespace RentCar.Infrastructure.Repositories
{
    public class CarBrandRepository<TDbContext> : Repository<TDbContext, CarBrand> where TDbContext : DbContext
    {
        public CarBrandRepository(TDbContext dbContext) : base(dbContext){}
    }
}
