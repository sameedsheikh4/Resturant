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
        private IEnumerable<BrandModel> IEnumerable { get; set; }
        private BrandModel Model { get; set; }

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
        public async Task<IActionResult> GetBrandsById(int Id)
        {
            logger.LogInfo(nameof(GetBrandsById));
            IEnumerable = mapper.Map<IEnumerable<BrandModel>>(await _brandService.GetBrandsByIdAsync(Id));
            return Ok(IEnumerable);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            IEnumerable = mapper.Map<IEnumerable<BrandModel>>(await _brandService.GetAll());
            return Ok(IEnumerable);
        }

        [HttpPost]
        public async Task<IActionResult> PostBrand(Brand Brand)
        {
            Model = mapper.Map<BrandModel>(await _brandService.AddBrandAsync(Brand));
            return Ok(Model);
        }

        [HttpPut]
        public async Task<IActionResult> PutBrand(Brand Brand)
        {
            IEnumerable = mapper.Map<IEnumerable<BrandModel>>(await _brandService.UpdateBrandAsync(Brand));
            return Ok(IEnumerable);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> IsActive(int Id)
        {
            IEnumerable = mapper.Map<IEnumerable<BrandModel>>(await _brandService.IsActive(Id));            
            return Ok(IEnumerable);
        }

    }
}
