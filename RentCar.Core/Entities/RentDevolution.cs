using RentCar.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Entities
{
   public class RentDevolution : Entity
   {
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? DevolutionDate { get; set; }
        public decimal AmountPerDay { get; set; }
        public int DayQuantity { get; set; }
        public string Comentary { get; set; }

        public virtual Car Car { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
    }
}
