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
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientViewModel>()
                .ForMember(dest => dest.PersonTypeName, opt => opt.MapFrom(src => src.PersonType.Name));

            CreateMap<ClientViewModel, Client>()
                .ForSourceMember(source => source.PersonTypeName, opt => opt.DoNotValidate());

            CreateMap<Client, ClientViewModelForCombox>();
        }
    }
}
