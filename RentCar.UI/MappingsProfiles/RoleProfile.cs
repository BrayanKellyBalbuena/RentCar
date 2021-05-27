using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.ViewModels;

namespace RentCar.UI.MappingsProfiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleViewModel>();
        }
    }
}
