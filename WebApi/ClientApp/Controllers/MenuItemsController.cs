using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Services.TypedClient;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    public class MenuItemsController : Controller
    {
        //protected readonly MenuItemClient _client;
        //protected readonly MenusClient _menuClient;
        //protected readonly MenuCategoriesClient _menuCategoriesClient;

        //IEnumerable<MenuItemDTO> List { get; set; }
        //MenuItemDTO Model { get; set; }
        //public MenuItemsController(MenuItemClient client, MenusClient menuClient, MenuCategoriesClient menuCategoriesClient)
        //{
        //    _client = client;
        //    _menuClient = menuClient;
        //    _menuCategoriesClient = menuCategoriesClient;
        //}

        public IActionResult Index()
        {
            return View();
            //try
            //{
            //    List = await _client.GetMenuItemsByIdAsync(1,4);
            //    if (List != null)
            //        return View(List);
            //    return View();
            //}
            //catch (Exception)
            //{
            //    return View();
            //}
        }

        //public async Task<IActionResult> Create(MenuItemDTO Entity)
        //{
        //    IEnumerable<MenuDTO> Menu = await _menuClient.GetMenusAsync();
        //    ViewBag.Menus = Menu;

        //    IEnumerable<MenuCategoryDTO> MenuCategory = await _menuCategoriesClient.GetMenuCategoriesAsync();
        //    ViewBag.MenuCat = MenuCategory;

        //    if (Entity.StoreId != 0)
        //    {
        //        Entity.CreatedBy = "sameed";
        //        Model = await _client.CreateMenuItemAsync(Entity);
        //        return View();
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        

    }
}
