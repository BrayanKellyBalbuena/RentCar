using RentCar.Core.Entities;
using RentCar.Core.Interfaces;

namespace RentCar.Infrastructure.Services
{
    public class CarService : EntityService<Car>
    {
        public CarService(IRepository<Car> repository) : base(repository)
        {
        }
    }
}
