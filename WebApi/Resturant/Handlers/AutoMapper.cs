using AutoMapper;
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
            CreateMap<IEnumerable<Brand>, IEnumerable<BrandModel>>();
            //CreateMap<BrandModel, Brand>();
        }
    }
}
