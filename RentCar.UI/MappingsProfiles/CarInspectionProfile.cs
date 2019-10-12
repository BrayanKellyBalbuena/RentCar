using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.ViewModels;

namespace RentCar.UI.MappingsProfiles
{
    public class CarInspectionProfile : Profile
    {
        public CarInspectionProfile()
        {
            CreateMap<CarInspection, CarInspectionViewModel>().ReverseMap();
        }
    }
}
