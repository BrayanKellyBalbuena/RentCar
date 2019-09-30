using RentCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Repositories
{
    public class PersonTypeRepository<TDbContext> : Repository<TDbContext, PersonType> where TDbContext : DbContext
    {
        public PersonTypeRepository(TDbContext context) : base(context)
        {
        }
    }
}
