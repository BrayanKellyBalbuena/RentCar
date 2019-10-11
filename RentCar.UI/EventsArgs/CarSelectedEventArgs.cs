using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.EventsArgs
{
    public class CarSelectedEventArgs : EventArgs
    {
        public CarViewModel Car { get; set; }
    }
}
