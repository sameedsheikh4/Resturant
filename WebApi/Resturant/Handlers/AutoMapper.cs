using AutoMapper;
using Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Handlers
{
    public class AutoMapper : Profile   
    {
        public AutoMapper()
        {
            CreateMap<Brand, BrandModel>();
            CreateMap<Item, ItemModel>();
            CreateMap<Menu, MenuModel>();
        }
    }
}
