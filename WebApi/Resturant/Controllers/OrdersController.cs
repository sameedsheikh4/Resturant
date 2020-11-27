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
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService service;
        private readonly IMapper mapper;
        private IEnumerable<StoreOrderDTO> OrderList { get; set; }
        private StoreOrderDTO OrderModel { get; set; }
        private OrderStatusDTO StatusModel { get; set; }
        public OrdersController(IOrdersService Service, IMapper Mapper)
        {
            service = Service;
            mapper = Mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            OrderList = mapper.Map<IEnumerable<StoreOrderDTO>>(await service.GetAllAsync());
            return Ok(OrderList);
        }

        [HttpGet("{StoreId}")]
        public async Task<IActionResult> GetOrdersById(int StoreId)
        {
            OrderList = mapper.Map<IEnumerable<StoreOrderDTO>>(await service.GetOrdersByIdAsync(StoreId));
            return Ok(OrderList);
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder(StoreOrder Entity)
        {
            OrderModel = mapper.Map<StoreOrderDTO>(await service.AddOrderAsync(Entity));
            return Ok(OrderModel);
        }

        [HttpPut]
        public async Task<IActionResult> PutOrder(StoreOrder Entity)
        {
            OrderModel = mapper.Map<StoreOrderDTO>(await service.UpdateOrderAsync(Entity));
            return Ok(OrderModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> IsArchive(int Id)
        {
            OrderModel = mapper.Map<StoreOrderDTO>(await service.IsArchive(Id));
            return Ok(OrderModel);
        }
    }
}
