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
            CreateMap<Brand, BrandDTO>();
            CreateMap<Item, ItemDTO>();
            CreateMap<ItemPhoto, ItemPhotoDTO>();
            CreateMap<Menu, MenuDTO>();
            CreateMap<MenuCategory, MenuCategoryDTO>();
            CreateMap<MenuItem, MenuItemDTO>();
            CreateMap<StoreOrder, StoreOrderDTO>()
                .ForMember(a => a.DeliveryAddress, e => e.MapFrom( a=> new DeliveryAddress()));

            CreateMap<DeliveryAddress, DeliveryAddressDTO>();
            CreateMap<Status, StatusDTO>();
            CreateMap<Rider, RiderDTO>();
        }
    }
}
