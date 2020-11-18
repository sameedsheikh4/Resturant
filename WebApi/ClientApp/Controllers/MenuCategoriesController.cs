using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Services.TypedClient;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    public class MenuCategoriesController : Controller
    {
        protected readonly MenuCategoriesClient _client;

        IEnumerable<MenuCategoryDTO> List { get; set; }
        MenuCategoryDTO Model { get; set; }
        public MenuCategoriesController(MenuCategoriesClient Client)
        {
            _client = Client;
        }
        public async Task<IActionResult> Index()
        {
            List = await _client.GetMenuCategoriesAsync();
            return View(List);
        }

        public async Task<IActionResult> Create(MenuCategoryDTO Entity)
        {
            if (ModelState.IsValid)
            {
                Model = await _client.CreateMenuCategoryAsync(Entity);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }       

    }
}
