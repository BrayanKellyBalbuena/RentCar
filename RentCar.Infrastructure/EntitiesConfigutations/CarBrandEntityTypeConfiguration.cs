using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.EntitiesConfigutations
{
    internal class CarBrandEntityTypeConfiguration : EntityTypeConfiguration<CarBrand>
    {
        public CarBrandEntityTypeConfiguration()
        {
            ToTable("CarBrands");
        }
    }
}
