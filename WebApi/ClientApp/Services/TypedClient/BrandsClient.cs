using ClientApp.Models;
using Newtonsoft.Json;
using Services;
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
        public HttpClientHelper Helper { get; }

        public BrandModel Model;
        public BrandsClient(HttpClient Client, HttpClientHelper helper)
        {
            this.Client = Client;
            Helper = helper;
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

            HttpContent BrandModelJson = Helper.CreateHttpContent<BrandModel>(BrandModel);

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
            HttpContent BrandModelJson = Helper.CreateHttpContent<BrandModel>(BrandModel);

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
