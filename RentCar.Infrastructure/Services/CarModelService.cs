using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Infrastructure.Abstractions;

namespace RentCar.Infrastructure.Services
{
    public class CarModelService : EntityService<CarModel>
    {
        public CarModelService(IRepository<CarModel> repository) : base(repository)
        {
        }
    }
}
