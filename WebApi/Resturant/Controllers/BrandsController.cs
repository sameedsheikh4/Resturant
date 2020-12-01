using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Interfaces;
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
        private IEnumerable<BrandDTO> IEnumerable { get; set; }
        private BrandDTO Model { get; set; }

        public BrandsController(IBrandService BrandService, IMapper Mapper, IloggerManager Logger)
        {
            _brandService = BrandService;
            mapper = Mapper;
            logger = Logger;
        }
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<IActionResult>> DeleteBrand(int Id)
        //{
        //    logger.LogInfo(nameof(DeleteBrand));
        //    return await _brandService.DeleteBrandAsync(Id);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandsById(int Id)
        {
            logger.LogInfo(nameof(GetBrandsById));
            IEnumerable = mapper.Map<IEnumerable<BrandDTO>>(await _brandService.GetBrandsByIdAsync(Id));
            return Ok(IEnumerable);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            IEnumerable = mapper.Map<IEnumerable<BrandDTO>>(await _brandService.GetAll());
            return Ok(IEnumerable);
        }

        [HttpPost]
        public async Task<IActionResult> PostBrand(Brand Entity)
        {
            Model = mapper.Map<BrandDTO>(await _brandService.AddBrandAsync(Entity));
            return Ok(Model);
        }

        [HttpPut]
        public async Task<IActionResult> PutBrand(Brand Entity)
        {
            IEnumerable = mapper.Map<IEnumerable<BrandDTO>>(await _brandService.UpdateBrandAsync(Entity));
            return Ok(IEnumerable);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> IsActive(int Id)
        {
            IEnumerable = mapper.Map<IEnumerable<BrandDTO>>(await _brandService.IsActive(Id));            
            return Ok(IEnumerable);
        }

    }
}
