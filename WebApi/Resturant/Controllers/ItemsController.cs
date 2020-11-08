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
        private IEnumerable<ItemModel> List { get; set; }
        private ItemModel Model { get; set; }
        public ItemsController(IItemService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItemsById(int Id)
        {
            //logger.LogInfo(nameof(GetBrandsById));
            List = mapper.Map<IEnumerable<ItemModel>>(await service.GetItemsByIdAsync(Id));
            return Ok(List);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            List = mapper.Map<IEnumerable<ItemModel>>(await service.GetAll());
            return Ok(List);
        }
        [HttpPost]
        public async Task<IActionResult> PostItem(Item Item)
        {
            Model = mapper.Map<ItemModel>(await service.AddItemAsync(Item));
            return Ok(Model);
        }
        [HttpPut]
        public async Task<IActionResult> PutItem(Item Item)
        {
            Model = mapper.Map<ItemModel>(await service.UpdateItemAsync(Item));
            return Ok(Model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            Model = mapper.Map<ItemModel>(await service.IsArchive(Id));
            return Ok(Model);
        }

    }
}
