using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClientApp.Services.TypedClient;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    public class MenusController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        protected MenusClient _client;
        IEnumerable<MenuModel> List { get; set; }
        MenuModel Model { get; set; }
        public MenusController(IHttpClientFactory httpClientFactory, MenusClient client)
        {
            _clientFactory = httpClientFactory;
            _client = client;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                List = await _client.GetMenusAsync();
                if (List != null)
                    return View(List);
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
        public async Task<IActionResult> Create(MenuModel Entity)
        {
            if (Entity.StoreId != 0)
            {
                Model = await _client.CreateMenuAsync(Entity);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> Delete(int Id)
        {
            await _client.DeleteMenuAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
