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
        public HttpClient Client { get; }
        public IHttpClientHelper Helper { get; }
        public ItemModel Model;
        public ItemsClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }
        public async Task<IEnumerable<ItemModel>> GetItemsAsync()
        {
            var Response = await Client.GetAsync("api/Items");
            Response.EnsureSuccessStatusCode();
            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ItemModel>>(ResponseStream);
        }
        public async Task<IEnumerable<ItemModel>> GetItemsByIdAsync(int Id)
        {
            var Response = await Client.GetAsync($"api/Items/{Id}");
            Response.EnsureSuccessStatusCode();
            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<ItemModel>>(ResponseStream);
        }
        public async Task<ItemModel> CreateItemAsync(ItemModel itemModel)
        {

            HttpContent ModelJson = Helper.CreateHttpContent(itemModel);

            var HttpResponse =
                await Client.PostAsync("api/Items", ModelJson);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var responseStream = await HttpResponse.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<ItemModel>(responseStream);
            }

            HttpResponse.EnsureSuccessStatusCode();

            return Model;
        }
        public async Task<ItemModel> UpdateItemAsync(ItemModel itemModel)
        {
            HttpContent ModelJson = Helper.CreateHttpContent(itemModel);

            var HttpResponse =
                await Client.PutAsync("api/Items", ModelJson);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var responseStream = await HttpResponse.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<ItemModel>(responseStream);
            }

            HttpResponse.EnsureSuccessStatusCode();

            return Model;
        }
        public async Task DeleteItemAsync(int Id)
        {
            var HttpResponse =
                await Client.DeleteAsync($"api/Items/{Id}");

            HttpResponse.EnsureSuccessStatusCode();
        }
    }
}
