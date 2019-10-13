using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using RentCar.Infrastructure.Constants;

namespace RentCar.Infrastructure.EntitiesConfigutations
{
    internal class RentDevolutionEntityConfiguration : EntityConfiguration<RentDevolution>
    {
        public RentDevolutionEntityConfiguration()
        {
            ToTable(DbConstants.RENT_DEVOLUTION_TABLE);
        }
    }
}
