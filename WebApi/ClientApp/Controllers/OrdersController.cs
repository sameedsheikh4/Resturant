using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClientApp.Mapping;
using ClientApp.Services.TypedClient;
using ClientApp.ViewModels;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    public class OrdersController : Controller
    {
        private protected readonly OrdersClient _client;
        private protected IMapper mapper;
        IEnumerable<StoreOrderViewModel> List { get; set; }
        StoreOrderViewModel Model { get; set; }

        public OrdersController(OrdersClient Client, IMapper Mapping)
        {
            _client = Client;
            this.mapper = Mapping;
        }
        public async Task<IActionResult> Index()
        {
            List = mapper.Map<IEnumerable<StoreOrderViewModel>>(await _client.GetOrdersAsync());
            if (List != null)
                return View(List);
            return View();
        }

        public async Task<IActionResult> Create(StoreOrderDTO Entity)
        {
            if (ModelState.IsValid)
            {
                Entity.CreatedBy = "sameed";
                Model = mapper.Map<StoreOrderViewModel>(await _client.CreateOrdersAsync(Entity));
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int Id)
        {
            await _client.DeleteOrdersAsync(Id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int Id)
        {
            List = mapper.Map<IEnumerable<StoreOrderViewModel>>(await _client.GetOrdersByIdAsync(Id));
            Model = List.First();
            return View(Model);
        }

        public async Task<IActionResult> Update(StoreOrderDTO Entity)
        {
            try
            {
                Entity.ModifiedBy = "sameed";
                Entity.ModifiedDate = DateTime.Now;
                Model = mapper.Map<StoreOrderViewModel>(await _client.UpdateOrdersAsync(Entity));
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Edit));
            }
        }
    }
}
