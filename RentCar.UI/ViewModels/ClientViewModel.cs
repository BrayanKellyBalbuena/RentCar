using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.ViewModels
{
   public class ClientViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string IdentificationCard { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal CreditLimit { get; set; }
        public int PersonTypeId { get; set; }
        public string PersonTypeName { get; set; }
    }
}
