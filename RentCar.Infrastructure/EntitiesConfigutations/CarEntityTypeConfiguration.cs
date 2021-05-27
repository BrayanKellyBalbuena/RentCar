using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using RentCar.Infrastructure.Constants;

namespace RentCar.Infrastructure.EntitiesConfigutations
{
    internal class CarEntityTypeConfiguration : EntityConfiguration<Car>
    {
        public CarEntityTypeConfiguration()
        {
            Property(x => x.ChassisNumber).HasMaxLength(IdentificationDocumentsLengthNumber.CHASSIS_NUMBER);
        }
    }
}
