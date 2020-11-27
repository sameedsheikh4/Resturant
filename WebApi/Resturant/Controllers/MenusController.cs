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
    public class MenusController : ControllerBase
    {
        private readonly IMenusService service;
        private readonly IMapper mapper;
        private IEnumerable<MenuDTO> List { get; set; }
        private MenuDTO Model { get; set; }

        public MenusController(IMenusService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{StoreId}")]
        public async Task<IActionResult> GetMenusById(int StoreId)
        {
            //logger.LogInfo(nameof(GetBrandsById));
            List = mapper.Map<IEnumerable<MenuDTO>>(await service.GetMenusByIdAsync(StoreId));
            return Ok(List);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMenus()
        {
            List = mapper.Map<IEnumerable<MenuDTO>>(await service.GetAll());
            return Ok(List);
        }
        [HttpPost]
        public async Task<IActionResult> PostItem(Menu Entity)
        {
            Model = mapper.Map<MenuDTO>(await service.AddMenuAsync(Entity));
            return Ok(Model);
        }
        [HttpPut]
        public async Task<IActionResult> PutItem(Menu Entity)
        {
            Model = mapper.Map<MenuDTO>(await service.UpdateMenuAsync(Entity));
            return Ok(Model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            Model = mapper.Map<MenuDTO>(await service.IsArchive(Id));
            return Ok(Model);
        }
    }
}
