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
    public class FluelCategoryProfile :Profile
    {
        public FluelCategoryProfile()
        {
            CreateMap<FluelCategoryViewModel, FluelCategory>().ReverseMap();

            CreateMap<FluelCategory, FluelCategoryViewModelForComboBox>();
        }
    }
}
