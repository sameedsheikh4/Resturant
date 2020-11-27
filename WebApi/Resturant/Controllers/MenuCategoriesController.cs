using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Interfaces.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuCategoriesController : ControllerBase
    {
        private readonly IMenuCategoryService service;
        private readonly IMapper mapper;
        private IEnumerable<MenuCategory> List;
        private MenuCategory Model;
        public MenuCategoriesController(IMenuCategoryService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{StoreId}")]
        public async Task<IActionResult> GetMenuCategoryById(int StoreId)
        {
            //logger.LogInfo(nameof(GetBrandsById));
            List = mapper.Map<IEnumerable<MenuCategory>>(await service.GetMenuCategoriesByIdAsync(StoreId));
            return Ok(List);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMenuCategories()
        {
            List = mapper.Map<IEnumerable<MenuCategory>>(await service.GetAll());
            return Ok(List);
        }

        [HttpPost]
        public async Task<IActionResult> PostItem(MenuCategory Entity)
        {
            Model = mapper.Map<MenuCategory>(await service.AddMenuCategoryAsync(Entity));
            return Ok(Model);
        }

        [HttpPut]
        public async Task<IActionResult> PutItem(MenuCategory Entity)
        {
            Model = mapper.Map<MenuCategory>(await service.UpdateMenuCategoryAsync(Entity));
            return Ok(Model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            Model = mapper.Map<MenuCategory>(await service.IsArchive(Id));
            return Ok(Model);
        }
    }
}
