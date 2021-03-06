﻿using System;
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
        protected MenusClient _client;
        IEnumerable<MenuDTO> List { get; set; }
        MenuDTO Model { get; set; }
        public MenusController(MenusClient client)
        {
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
        public async Task<IActionResult> Create(MenuDTO Entity)
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
        public async Task<IActionResult> Edit(int Id)
        {
            List = await _client.GetMenusByIdAsync(Id);
            Model = List.First();
            return View(Model);
        }
        public async Task<IActionResult> Update(MenuDTO Entity)
        {
            try
            {
                Entity.ModifiedBy = "sameed";
                Entity.ModifiedDate = DateTime.Now;
                Model = await _client.UpdateMenuAsync(Entity);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Edit));
            }
        }

    }
}
