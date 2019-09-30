using RentCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Repositories
{
    public class ClientRepository<TDbContext> : Repository<TDbContext, Client> where TDbContext : DbContext
    {
        public ClientRepository(TDbContext context) : base(context)
        {

        }
    }
}
