using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.ViewModels
{
    public abstract class CatalogViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
