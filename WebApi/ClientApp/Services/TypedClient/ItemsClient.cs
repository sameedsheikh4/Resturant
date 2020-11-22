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
    public class ItemsClient
    {
        private readonly HttpClient Client;
        private readonly IHttpClientHelper Helper;

        private ItemDTO Model;
        public ItemsClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }
        public async Task<IEnumerable<ItemDTO>> GetItemsAsync()
        {
            var HttpResponse = await Client.GetAsync("api/Items");

            return await Helper.ResponseParsingListAsync<ItemDTO>(HttpResponse);
        }
        public async Task<IEnumerable<ItemDTO>> GetItemsByIdAsync(int Id)
        {
            var HttpResponse = await Client.GetAsync($"api/Items/{Id}");

            return await Helper.ResponseParsingListAsync<ItemDTO>(HttpResponse);
        }
        public async Task<ItemDTO> CreateItemAsync(ItemDTO Entity)
        {

            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PostAsync("api/Items", content);

            Model = await Helper.ResponseParsingAsync<ItemDTO>(HttpResponse);

            return Model;
        }
        public async Task<ItemDTO> UpdateItemAsync(ItemDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PutAsync("api/Items", content);

            if (HttpResponse.IsSuccessStatusCode)
                Model = await Helper.ResponseParsingAsync<ItemDTO>(HttpResponse);

            return Model;
        }
        public async Task DeleteItemAsync(int Id)
        {
            await Client.DeleteAsync($"api/Items/{Id}");
        }
    }
}
