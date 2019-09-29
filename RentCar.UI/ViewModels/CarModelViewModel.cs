using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.ViewModels
{
    public class CarModelViewModel : CatalogViewModel
    {
        public int CarBrandId { get; set; }
        public string CarBrandName { get; set; }
    }
}
