﻿using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.UI.MappingsProfiles
{
    public class UserRoleProfile : Profile
    {

        public UserRoleProfile()
        {
            CreateMap<UserRole, UserRoleViewModel>();
        }
    }
}
