using RentCar.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.ViewModels
{
    public class UserRoleViewModel : EntityViewModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public  UserViewModel User { get; set; }
        public  RoleViewModel Role { get; set; }
    }
}
