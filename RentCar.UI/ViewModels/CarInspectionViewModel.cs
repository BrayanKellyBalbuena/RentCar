using System;

namespace RentCar.UI.ViewModels
{
    public class CarInspectionViewModel : EntityViewModel
    {
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public bool HasScratch { get; set; }
        public bool HasTires { get; set; }
        public float FluelQuantity { get; set; }
        public bool HasHydraulicJack { get; set; }
        public bool HasReplacementTires { get; set; }
        public bool HasBrokenCrystal { get; set; }
        public bool FrontRightTireState { get; set; }
        public bool FrontLeftTireState { get; set; }
        public bool BackRightTireState { get; set; }
        public bool BackLeftTireState { get; set; }
        public DateTime InspectionsDate { get; set; }
    }
}
