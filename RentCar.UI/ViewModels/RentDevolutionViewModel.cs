using RentCar.UI.Abstractions;
using System;

namespace RentCar.UI.ViewModels
{
    public class RentDevolutionViewModel : EntityViewModel
    {
        public int EmployeeId { get; set; }
        public string Employee { get; set; }
        public int ClientId { get; set; }
        public string Client { get; set; }
        public int CarId { get; set; }
        public string Car { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public decimal AmountPerDay { get; set; }
        public int DayQuantity { get; set; }
        public string Comentary { get; set; }
    }
}
