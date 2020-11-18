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
        private readonly HttpClient Client;
        private readonly IHttpClientHelper Helper;
        public MenuDTO Model;

        public MenusClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }

        public async Task<IEnumerable<MenuDTO>> GetMenusAsync()
        {
            var HttpResponse = await Client.GetAsync("api/Menus");
            return await Helper.ResponseParsingListAsync<MenuDTO>(HttpResponse);
        }
        public async Task<IEnumerable<MenuDTO>> GetMenusByIdAsync(int Id)
        {
            var HttpResponse = await Client.GetAsync($"api/Menus/{Id}");

            return await Helper.ResponseParsingListAsync<MenuDTO>(HttpResponse);
        }
        public async Task<MenuDTO> CreateMenuAsync(MenuDTO Entity)
        {

            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PostAsync("api/Menus", content);

            if (HttpResponse.IsSuccessStatusCode)
                Model = await Helper.ResponseParsingAsync<MenuDTO>(HttpResponse);

            return Model;
        }
        public async Task<MenuDTO> UpdateMenuAsync(MenuDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PutAsync("api/Menus", content);

            if (HttpResponse.IsSuccessStatusCode)
                Model = await Helper.ResponseParsingAsync<MenuDTO>(HttpResponse);

            return Model;
        }
        public async Task DeleteMenuAsync(int Id)
        {
            await Client.DeleteAsync($"api/Menus/{Id}");
        }
    }
}
