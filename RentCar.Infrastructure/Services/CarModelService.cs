using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Infrastructure.Services;

namespace RentCar.Infrastructure.Services
{
    public class CarModelService : EntityService<CarModel>
    {
        public CarModelService(IRepository<CarModel> repository) : base(repository)
        {
        }
    }
}
