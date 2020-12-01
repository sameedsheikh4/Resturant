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
            CreateMap<Item, ItemDTO>()
                .ForMember(a => a.ItemPhoto, e => e.MapFrom(a => new ItemPhoto()));
            CreateMap<ItemPhoto, ItemPhotoDTO>();
            CreateMap<Menu, MenuDTO>();
            CreateMap<MenuCategory, MenuCategoryDTO>();
            CreateMap<MenuItem, MenuItemDTO>()
                .ForMember(a => a.Menu, e => e.MapFrom(a => new Menu()))
                .ForMember(a => a.Item, e => e.MapFrom(a => new Item()));
            CreateMap<StoreOrder, StoreOrderDTO>()
                .ForMember(a => a.DeliveryAddress, e => e.MapFrom(a => new DeliveryAddress()));

            CreateMap<DeliveryAddress, DeliveryAddressDTO>();
            CreateMap<Status, StatusDTO>();
            CreateMap<Rider, RiderDTO>();
            CreateMap<OrderRider, OrderRiderDTO>();
        }
    }
}
