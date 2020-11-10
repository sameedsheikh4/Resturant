using Common.DTOs;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Services.TypedClient
{
    public class MenusClient
    {
        public HttpClient Client { get; }
        public IHttpClientHelper Helper { get; }
        public MenuModel Model;

        public MenusClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }

        public async Task<IEnumerable<MenuModel>> GetMenusAsync()
        {
            var Response = await Client.GetAsync("api/Menus");
            Response.EnsureSuccessStatusCode();
            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<MenuModel>>(ResponseStream);
        }
        public async Task<IEnumerable<MenuModel>> GetMenusByIdAsync(int Id)
        {
            var Response = await Client.GetAsync($"api/Menus/{Id}");
            Response.EnsureSuccessStatusCode();
            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<MenuModel>>(ResponseStream);
        }
        public async Task<MenuModel> CreateMenuAsync(MenuModel menuModel)
        {

            HttpContent ModelJson = Helper.CreateHttpContent(menuModel);

            var HttpResponse =
                await Client.PostAsync("api/Menus", ModelJson);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var responseStream = await HttpResponse.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<MenuModel>(responseStream);
            }

            HttpResponse.EnsureSuccessStatusCode();

            return Model;
        }
        public async Task<MenuModel> UpdateMenuAsync(MenuModel menuModel)
        {
            HttpContent ModelJson = Helper.CreateHttpContent(menuModel);

            var HttpResponse =
                await Client.PutAsync("api/Menus", ModelJson);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var responseStream = await HttpResponse.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<MenuModel>(responseStream);
            }

            HttpResponse.EnsureSuccessStatusCode();

            return Model;
        }
        public async Task DeleteMenuAsync(int Id)
        {
            var HttpResponse =
                await Client.DeleteAsync($"api/Menus/{Id}");

            HttpResponse.EnsureSuccessStatusCode();
        }
    }
}
