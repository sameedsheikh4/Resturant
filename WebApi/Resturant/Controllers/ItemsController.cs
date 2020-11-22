using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Interfaces.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService service;
        private readonly IMapper mapper;
        private IEnumerable<ItemDTO> List { get; set; }
        private ItemDTO Model { get; set; }
        public ItemsController(IItemService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItemsById(int Id)
        {
            //logger.LogInfo(nameof(GetBrandsById));
            List = mapper.Map<IEnumerable<ItemDTO>>(await service.GetItemsByIdAsync(Id));
            return Ok(List);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            List = mapper.Map<IEnumerable<ItemDTO>>(await service.GetAllAsync());
            return Ok(List);
        }
        [HttpPost]
        public async Task<IActionResult> PostItem(Item Entity)
        {
            Model = mapper.Map<ItemDTO>(await service.AddItemAsync(Entity));
            return Ok(Model);
        }
        [HttpPut]
        public async Task<IActionResult> PutItem(Item Entity)
        {
            Model = mapper.Map<ItemDTO>(await service.UpdateItemAsync(Entity));
            return Ok(Model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            Model = mapper.Map<ItemDTO>(await service.IsArchive(Id));
            return Ok(Model);
        }

    }
}
