using RentCar.Core.Entities;
using RentCar.UI.Abstractions;
using System.Collections.Generic;

namespace RentCar.UI.ViewModels
{
    public class UserViewModel : EntityViewModel
    {
        public int EmployeeId { get; set; }
        public string Employee { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public HashSet<UserRole> UserRoles { get; set; }
    }
}
