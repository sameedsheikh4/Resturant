using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Interfaces.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly IMapper mapper;
        private readonly IloggerManager logger;

        public BrandsController(IBrandService BrandService, IMapper Mapper, IloggerManager Logger)
        {
            _brandService = BrandService;
            mapper = Mapper;
            logger = Logger;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteBrand(int Id)
        {
            logger.LogInfo(nameof(DeleteBrand));
            return await _brandService.DeleteBrandAsync(Id);
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<Brand>> GetBrandsById(int Id)
        {
            logger.LogInfo(nameof(GetBrandsById));
            return await _brandService.GetBrandsByIdAsync(Id);
        }

        [HttpGet]
        public async Task<IEnumerable<Brand>> GetAllBrands()
        {
            IEnumerable<Brand> Model = await _brandService.GetAll();
            return (IEnumerable<Brand>)mapper.Map<BrandModel>(Model);

        }

        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand Brand)
        {
            return await _brandService.AddBrandAsync(Brand);
        }

        [HttpPut]
        public async Task<ActionResult<Brand>> PutBrand(Brand Brand)
        {
            return await _brandService.UpdateBrandAsync(Brand);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Brand>> IsActive(int Id)
        {
            return await _brandService.IsActive(Id);
        }

    }
}
