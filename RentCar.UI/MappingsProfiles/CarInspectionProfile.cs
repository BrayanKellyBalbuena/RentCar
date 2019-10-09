﻿using AutoMapper;
using RentCar.Core.Entities;
using RentCar.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
