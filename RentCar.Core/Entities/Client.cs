using RentCar.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Entities
{
   public class Client : Entity
    {
        public string Name { get; set; }
        public string IdentificationCard { get; set; }
        public decimal CreditLimit { get; set; }
        public int PersonTypeId { get; set; }
        public virtual PersonType PersonType{ get; set; }
    }
}
