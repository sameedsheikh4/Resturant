using Common.DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Services.TypedClient
{
    public class MenuItemClient
    {
        private readonly HttpClient Client;
        private readonly IHttpClientHelper Helper;

        public MenuItemDTO Model;
        public MenuItemClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }

        public async Task<IEnumerable<MenuItemDTO>> GetMenuItemsAsync()
        {
            var HttpResponse = await Client.GetAsync("api/MenuItems");

            return await Helper.ResponseParsingListAsync<MenuItemDTO>(HttpResponse);
        }

        public async Task<IEnumerable<MenuItemDTO>> GetMenuItemsByIdAsync(int Id)
        {
            var HttpResponse = await Client.GetAsync($"api/MenuItems/{Id}");

            return await Helper.ResponseParsingListAsync<MenuItemDTO>(HttpResponse);
        }

        public async Task<MenuItemDTO> CreateMenuItemAsync(MenuItemDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse = await Client.PostAsync("api/MenuItems", content);
            Model = await Helper.ResponseParsingAsync<MenuItemDTO>(HttpResponse);

            return Model;
        }

        public async Task<MenuItemDTO> UpdateMenuItemAsync(MenuItemDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PutAsync("api/MenuItems", content);
            Model = await Helper.ResponseParsingAsync<MenuItemDTO>(HttpResponse);

            return Model;
        }
        public async Task DeleteMenuItemAsync(int Id)
        {
            await Client.DeleteAsync($"api/MenuItems/{Id}");
        }
    }
}
