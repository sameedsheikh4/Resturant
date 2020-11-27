using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Interfaces.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMenuItemService service;
        private readonly IMapper mapper;

        private IEnumerable<MenuItemDTO> List { get; set; }
        private MenuItemDTO Model { get; set; }

        public MenuItemsController(IMenuItemService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{StoreId}/{MenuId}")]
        public async Task<IActionResult> GetMenuItemsById(int StoreId, int MenuId)
        {
            //logger.LogInfo(nameof(GetBrandsById));
            List = mapper.Map<IEnumerable<MenuItemDTO>>(await service.GetMenuItemsByIdAsync(StoreId, MenuId));
            return Ok(List);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMenuItems()
        {
            List = mapper.Map<IEnumerable<MenuItemDTO>>(await service.GetAll());
            return Ok(List);
        }
        [HttpPost]
        public async Task<IActionResult> PostItem(MenuItem Entity)
        {
            Model = mapper.Map<MenuItemDTO>(await service.AddMenuItemAsync(Entity));
            return Ok(Model);
        }
        [HttpPut]
        public async Task<IActionResult> PutItem(MenuItem Entity)
        {
            Model = mapper.Map<MenuItemDTO>(await service.UpdateMenuItemAsync(Entity));
            return Ok(Model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            Model = mapper.Map<MenuItemDTO>(await service.IsArchive(Id));
            return Ok(Model);
        }
    }
}
