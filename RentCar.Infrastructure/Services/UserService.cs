using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Infrastructure.Abstractions;

namespace RentCar.Infrastructure.Services
{
    public class UserService : EntityService<User>
    {
        public UserService(IRepository<User> repository) : base(repository)
        {
        }
    }
}
