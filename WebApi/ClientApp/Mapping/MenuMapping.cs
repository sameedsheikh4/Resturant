using AutoMapper;
using System;
using Common.DTOs;
using ClientApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Mapping
{
    public class MenuMapping : Profile
    {
        public MenuMapping()
        {
            CreateMap<MenuDTO, MenuViewModel>();
            CreateMap<MenuViewModel, MenuDTO>();
        }
    }
}
