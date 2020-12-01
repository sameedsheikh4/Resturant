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
    public class OrderRiderController : ControllerBase
    {
        private readonly IRiderOrderService service;
        private readonly IMapper mapper;
        private IEnumerable<OrderRiderDTO> List { get; set; }
        private OrderRiderDTO Model { get; set; }
        public OrderRiderController(IRiderOrderService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }

        [HttpGet("{OrderId}")]
        public async Task<IActionResult> GetOrdersByIdAsync(int OrderId)
        {
            List = mapper.Map<IEnumerable<OrderRiderDTO>>(await service.GetOrderByIdAsync(OrderId));
            return Ok(List);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrderRider(OrderRider Entity)
        {
            Model = mapper.Map<OrderRiderDTO>(await service.AssignOrderToRiderAsync(Entity));
            return Ok(Model);
        }

        [HttpPut]
        public async Task<IActionResult> PutOrderRider(OrderRider Entity)
        {
            Model = mapper.Map<OrderRiderDTO>(await service.UpdateDeliveryInfoAsync(Entity));
            return Ok(Model);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            await service.IsArchive(Id);
            return NoContent();
        }
    }
}
