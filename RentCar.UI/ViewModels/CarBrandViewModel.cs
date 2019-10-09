using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.Abstractions
{
    public class CarBrandViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
