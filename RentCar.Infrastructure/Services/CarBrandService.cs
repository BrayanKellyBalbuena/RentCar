using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Infrastructure.Abstractions;

namespace RentCar.Infrastructure.Services
{
    public class CarBrandService : EntityService<CarBrand>
    {
        public CarBrandService(IRepository<CarBrand> repository) : base(repository)
        {
        }
    }
}
