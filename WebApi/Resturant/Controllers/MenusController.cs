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
        private IEnumerable<MenuModel> List { get; set; }
        private MenuModel Model { get; set; }

        public MenusController(IMenusService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenusById(int Id)
        {
            //logger.LogInfo(nameof(GetBrandsById));
            List = mapper.Map<IEnumerable<MenuModel>>(await service.GetMenusByIdAsync(Id));
            return Ok(List);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMenus()
        {
            List = mapper.Map<IEnumerable<MenuModel>>(await service.GetAll());
            return Ok(List);
        }
        [HttpPost]
        public async Task<IActionResult> PostItem(Menu Menu)
        {
            Model = mapper.Map<MenuModel>(await service.AddMenuAsync(Menu));
            return Ok(Model);
        }
        [HttpPut]
        public async Task<IActionResult> PutItem(Menu Menu)
        {
            Model = mapper.Map<MenuModel>(await service.UpdateMenuAsync(Menu));
            return Ok(Model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            Model = mapper.Map<MenuModel>(await service.IsArchive(Id));
            return Ok(Model);
        }
    }
}
