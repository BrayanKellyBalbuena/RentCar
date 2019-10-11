using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.Abstractions;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.MappingsProfiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarViewModel>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(source => source.CarCategory.Name))
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(source => source.CarBrand.Name))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(source => source.CarModel.Name))
                .ForMember(dest => dest.FluelCategory, opt => opt.MapFrom(source => source.FluelCategory.Name));

            CreateMap<CarViewModel, Car>()
                .ForSourceMember(source => source.Category, opt => opt.DoNotValidate())
                .ForSourceMember(source => source.Brand, opt => opt.DoNotValidate())
                .ForSourceMember(source => source.Model, opt => opt.DoNotValidate())
                .ForSourceMember(source => source.FluelCategory, opt => opt.DoNotValidate());

            CreateMap<Car, CarBrandViewModelForComboBox>();

            CreateMap<CarViewModel, CarViewModelForComboBox>();
        }
    }
}
