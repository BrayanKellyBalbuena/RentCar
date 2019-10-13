using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.ViewModels;

namespace RentCar.UI.MappingsProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>().ForMember(dest => dest.Employee, opt => opt.MapFrom(source => source.Employee.Name));

        }
    }
}
