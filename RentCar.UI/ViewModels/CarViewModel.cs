using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.Abstractions
{
    public class CarViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string PlacaNumber { get; set; }
        public int CarCategoryId { get; set; }
        public int CarBrandId { get; set; }
        public int CarModelId { get; set; }
        public int FluelCategoryId { get; set; }
        public string Category { get; set; }
        public  string Brand { get; set; }
        public string Model  { get; set; }
        public string FluelCategory { get; set; }
    }
}
