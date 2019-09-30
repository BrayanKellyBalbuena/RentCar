using RentCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Core.Interfaces;

namespace RentCar.Infrastructure.Services
{
    public class ClientService : EntityService<Client>
    {
        public ClientService(IRepository<Client> repository) : base(repository)
        {
        }
    }
}
