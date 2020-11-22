using Common.DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Services.TypedClient
{
    public class OrdersClient
    {
        private readonly HttpClient Client;
        private readonly IHttpClientHelper Helper;

        private StoreOrderDTO Model;
        public OrdersClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }
        public async Task<IEnumerable<StoreOrderDTO>> GetOrdersAsync()
        {
            var HttpResponse = await Client.GetAsync("api/Orders");

            return await Helper.ResponseParsingListAsync<StoreOrderDTO>(HttpResponse);
        }

        public async Task<IEnumerable<StoreOrderDTO>> GetOrdersByIdAsync(int Id)
        {
            var HttpResponse = await Client.GetAsync($"api/Orders/{Id}");

            return await Helper.ResponseParsingListAsync<StoreOrderDTO>(HttpResponse);
        }

        public async Task<StoreOrderDTO> CreateOrdersAsync(StoreOrderDTO Entity)
        {

            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PostAsync("api/Orders", content);

            Model = await Helper.ResponseParsingAsync<StoreOrderDTO>(HttpResponse);

            return Model;
        }

        public async Task<StoreOrderDTO> UpdateOrdersAsync(StoreOrderDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);

            var HttpResponse =
                await Client.PutAsync("api/Orders", content);

            if (HttpResponse.IsSuccessStatusCode)
                Model = await Helper.ResponseParsingAsync<StoreOrderDTO>(HttpResponse);

            return Model;
        }

        public async Task DeleteOrdersAsync(int Id)
        {
            await Client.DeleteAsync($"api/Orders/{Id}");
        }
    }
}
