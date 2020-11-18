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
    public class BrandsController : Controller
    {
        protected BrandsClient _client;
        public BrandDTO _model;
        public BrandsController(BrandsClient client)
        {
            _client = client;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                IEnumerable<BrandDTO> model = await _client.GetBrandsAsync();
                if (model != null)
                    return View(model);
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Insert(BrandDTO Brand)
        {
            try
            {
                Brand.CreatedBy = "sameed";

                BrandDTO model = await _client.CreateBrandsAsync(Brand);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.ToString());
                return RedirectToAction(nameof(Create));
            }
        }

        public async Task<IActionResult> Delete(int Id)
        {
            await _client.DeleteBrandAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
