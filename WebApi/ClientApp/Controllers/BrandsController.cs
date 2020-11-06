using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClientApp.TypedClient;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;

namespace ClientApp.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        protected BrandsClient _client;
        public BrandModel _model;
        public BrandsController(IHttpClientFactory clientFactory, BrandsClient client)
        {
            _clientFactory = clientFactory;
            _client = client;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                IEnumerable<BrandModel> model = await _client.GetBrandsAsync();
                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Insert(BrandModel Brand)
        {
            try
            {
                Brand.CreatedBy = "sameed";

                BrandModel model = await _client.CreateBrandsAsync(Brand);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.ToString());
                return RedirectToAction(nameof(Create));
            }
        }
    }
}
