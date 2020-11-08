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
    public class ItemsController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        protected ItemsClient _client;

        IEnumerable<ItemModel> List { get; set; }
        ItemModel Model { get; set; }

        public ItemsController(IHttpClientFactory clientFactory, ItemsClient client)
        {
            _clientFactory = clientFactory;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List = await _client.GetItemsAsync();
                if (List != null)
                    return View(List);
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        public async Task<IActionResult> Create(ItemModel Entity)
        {
            if (ModelState.IsValid)
            {                
                Model = await _client.CreateItemAsync(Entity);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int Id)
        {
            await _client.DeleteItemAsync(Id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int Id)
        {
            List = await _client.GetItemsByIdAsync(Id);
            return View(List);
        }

        public async Task<IActionResult> Update(ItemModel Entity)
        {
            try
            {
                Entity.ModifiedBy = "sameed";
                Entity.ModifiedDate = DateTime.Now;
                Model = await _client.UpdateItemAsync(Entity);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
