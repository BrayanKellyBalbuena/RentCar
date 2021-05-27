using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.Abstractions;
using RentCar.UI.ViewModels;

namespace RentCar.UI.MappingsProfiles
{
    public class CarModelProfile : Profile
    {
        public CarModelProfile()
        {
            CreateMap<CarModel, CarModelViewModel>()
                .ForMember(dest => dest.CarBrandName, opt => opt.MapFrom(src => src.CarBrand.Name))
                .ForMember(dest => dest.CarBrandId, opt => opt.MapFrom(src => src.CarBrandId));

            CreateMap<CarModelViewModel, CarModel>()
                .ForSourceMember(source => source.CarBrandName, opt => opt.DoNotValidate());

            CreateMap<CarModel, CarModelViewModelForComboBox>();
        }
    }
}
