using RentCar.Core.Abstractions;

namespace RentCar.Core.Entities
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public string IdentificationCard { get; set; }
    }
}
