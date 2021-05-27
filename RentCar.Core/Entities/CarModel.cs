using RentCar.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Entities
{
    public class CarModel :  Catalog
    {
        public int CarBrandId { get; set; }
        public virtual CarBrand CarBrand { get; set; }
    }
}
