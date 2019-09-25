using RentCar.Core.Entities;
using RentCar.Core.Interfaces;

namespace RentCar.Infrastructure.Services
{
    public class CarCategoryService : EntityService<CarCategory>
    {
        public CarCategoryService(IRepository<CarCategory> repository) : base(repository)
        {

        }
    }
}
