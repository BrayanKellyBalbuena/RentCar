using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.MappingsProfiles
{
    public class RentDevolutionProfile : Profile
    {
        public RentDevolutionProfile()
        {
            CreateMap<RentDevolution, RentDevolutionViewModel>()
                .ForMember(dest => dest.Client, opt => opt.MapFrom(source => source.Client.Name))
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(source => source.Employee.Name))
                .ForMember(dest => dest.Car, opt => opt.MapFrom(source => source.Car.Name));
        }
    }
}
