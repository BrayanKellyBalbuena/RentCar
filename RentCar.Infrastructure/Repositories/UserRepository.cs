using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using System.Data.Entity;

namespace RentCar.Infrastructure.Repositories
{
    public class UserRepository<TDbContext> : Repository<TDbContext, User> where TDbContext : DbContext
    {
        public UserRepository(TDbContext context) : base(context)
        {
        }
    }
}
