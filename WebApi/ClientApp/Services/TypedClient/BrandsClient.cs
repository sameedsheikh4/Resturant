using ClientApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace ClientApp.TypedClient
{
    public class BrandsClient
    {
        public HttpClient Client { get; }
        public BrandModel Model;
        public BrandsClient(HttpClient Client)
        {
            this.Client = Client;
        }
        public async Task<IEnumerable<BrandModel>> GetBrandsAsync()
        {
            var Response = await Client.GetAsync("api/Brands");
            Response.EnsureSuccessStatusCode();
            var ResponseStream = await Response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<BrandModel>>(ResponseStream);            
        }
        public async Task<BrandModel> CreateBrandsAsync(BrandModel BrandModel)
        {
            StringContent BrandModelJson = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(BrandModel),
                Encoding.UTF8,
                "application/json");

            using var HttpResponse =
                await Client.PostAsync("api/Brands", BrandModelJson);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var responseStream = await HttpResponse.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<BrandModel>(responseStream);
            }

            HttpResponse.EnsureSuccessStatusCode();

            return Model;
        }
        public async Task UpdateBrandAsync(BrandModel BrandModel)
        {
            StringContent BrandModelJson = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(BrandModel),
                Encoding.UTF8,
                "application/json");

            using var HttpResponse =
                await Client.PutAsync("Brands", BrandModelJson);

            HttpResponse.EnsureSuccessStatusCode();
        }
        public async Task DeleteBrandAsync(int Id)
        {
            using var HttpResponse =
                await Client.DeleteAsync($"Brands/{Id}");

            HttpResponse.EnsureSuccessStatusCode();
        }
    }
}
