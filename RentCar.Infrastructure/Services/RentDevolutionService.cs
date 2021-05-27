using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Services
{
    public class RentDevolutionService : EntityService<RentDevolution>
    {
        public RentDevolutionService(IRepository<RentDevolution> repository) : base(repository)
        {
        }
    }
}
