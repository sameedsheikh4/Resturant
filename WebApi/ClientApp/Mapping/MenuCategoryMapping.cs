using AutoMapper;
using Common.DTOs;
using ClientApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Mapping
{
    public class MenuCategoryMapping : Profile
    {
        public MenuCategoryMapping()
        {
            CreateMap<MenuCategoryDTO, MenuCategoryViewModel>();
            CreateMap<MenuCategoryViewModel, MenuCategoryDTO>();
        }
    }
}
