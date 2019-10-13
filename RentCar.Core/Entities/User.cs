using RentCar.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core.Entities
{
    public class User : Entity
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public virtual HashSet<UserRole> UserRoles { get; set; }
    }
}
