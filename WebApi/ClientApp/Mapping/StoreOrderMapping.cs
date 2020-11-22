using AutoMapper;
using Common.DTOs;
using ClientApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Mapping
{
    public class StoreOrderMapping : Profile
    {
        public StoreOrderMapping()
        {
            CreateMap<StoreOrderDTO, StoreOrderViewModel>();
            CreateMap<StoreOrderViewModel, StoreOrderDTO>();
        }
    }
}
