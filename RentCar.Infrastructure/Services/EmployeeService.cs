using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Infrastructure.Abstractions;

namespace RentCar.Infrastructure.Services
{
    public class EmployeeService : EntityService<Employee>
    {
        public EmployeeService(IRepository<Employee> repository) : base(repository)
        {
        }
    }
}
