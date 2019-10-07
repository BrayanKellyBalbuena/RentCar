using RentCar.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Entities
{
    public class Car : Entity
    {
        public string Name { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string PlacaNumber { get; set; }
        public int CarCategoryId { get; set; }
        public int CarBrandId { get; set; }
        public int  CarModelId{ get; set; }
        public int FluelCategoryId { get; set; }
        public virtual CarCategory CarCategory { get; set; }
        public virtual CarBrand  CarBrand{ get; set; }
        public virtual CarModel CarModel { get; set; }
        public virtual FluelCategory FluelCategory { get; set; }
    }
}
