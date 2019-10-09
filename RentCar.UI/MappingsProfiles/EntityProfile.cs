using AutoMapper;
using RentCar.Core.Abstractions;
using RentCar.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.MappingsProfiles
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<Entity, EntityViewModel>();

            CreateMap<EntityViewModel, Entity>()
                .ForSourceMember(source => source.CreatedDate, opt => opt.DoNotValidate());

        }
    }
}
