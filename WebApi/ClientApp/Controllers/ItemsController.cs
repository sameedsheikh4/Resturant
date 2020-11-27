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
        protected ItemsClient _client;

        IEnumerable<ItemDTO> List { get; set; }
        ItemDTO Model { get; set; }

        public ItemsController(ItemsClient client)
        {
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List = await _client.GetItemsByIdAsync(1);
                if (List != null)
                    return View(List);
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        public async Task<IActionResult> Create(ItemDTO Entity)
        {
            if (ModelState.IsValid)
            {
                Entity.StoreId = 1;
                Entity.CreatedBy = "sameed";
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
            Model = List.First();
            return View(Model);
        }

        public async Task<IActionResult> Update(ItemDTO Entity)
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
                return RedirectToAction(nameof(Edit));
            }
        }
    }
}
