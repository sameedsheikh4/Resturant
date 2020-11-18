using ClientApp.Models;
using Common.DTOs;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ClientApp.Services.TypedClient
{
    public class BrandsClient
    {
        private readonly HttpClient Client;
        private readonly IHttpClientHelper Helper;

        public BrandDTO Model;
        public BrandsClient(HttpClient Client, IHttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
        }
        public async Task<IEnumerable<BrandDTO>> GetBrandsAsync()
        {
            var Response = await Client.GetAsync("api/brands");

            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<BrandDTO>>(ResponseStream);            
        }
        public async Task<IEnumerable<BrandDTO>> GetBrandsByIdAsync(int Id)
        {
            var Response = await Client.GetAsync($"api/brands/{Id}");
            Response.EnsureSuccessStatusCode();
            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<BrandDTO>>(ResponseStream);
        }
        public async Task<BrandDTO> CreateBrandsAsync(BrandDTO Entity)
        {

            //HttpContent BrandModelJson = Helper.CreateHttpContent<BrandModel>(BrandModel);

            StringContent BrandModelJson = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(Entity),
                Encoding.UTF8,
                "application/json");

            var HttpResponse =
                await Client.PostAsync("api/Brands", BrandModelJson);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var responseStream = await HttpResponse.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<BrandDTO>(responseStream);
            }

            HttpResponse.EnsureSuccessStatusCode();

            return Model;
        }
        public async Task UpdateBrandAsync(BrandDTO Entity)
        {
            HttpContent BrandModelJson = Helper.CreateHttpContent<BrandDTO>(Entity);

            var HttpResponse =
                await Client.PutAsync("Brands", BrandModelJson);

            HttpResponse.EnsureSuccessStatusCode();
        }
        public async Task DeleteBrandAsync(int Id)
        {
            var HttpResponse =
                await Client.DeleteAsync($"api/Brands/{Id}");

            HttpResponse.EnsureSuccessStatusCode();
        }
    }
}
