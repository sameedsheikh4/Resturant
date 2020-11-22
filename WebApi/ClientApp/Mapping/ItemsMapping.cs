using AutoMapper;
using ClientApp.ViewModels;
using Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Mapping
{
    public class ItemsMapping : Profile
    {
        public ItemsMapping()
        {
            CreateMap<ItemDTO, ItemViewModel>();
            CreateMap<ItemViewModel, ItemDTO>();
        }
    }
}
