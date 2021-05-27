using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;

namespace RentCar.Infrastructure.EntitiesConfigutations
{
    internal class EmployeeEntityTypeConfiguration : EntityConfiguration<Employee>
    {
        public EmployeeEntityTypeConfiguration()
        {
            Property(e => e.IdentificationCard).HasMaxLength(11);
        }
    }
}
