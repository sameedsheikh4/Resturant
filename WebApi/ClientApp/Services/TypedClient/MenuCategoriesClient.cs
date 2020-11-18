using Common.DTOs;
using Microsoft.AspNetCore.Http;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Services.TypedClient
{
    public class MenuCategoriesClient
    {
        private readonly HttpClient Client;
        private readonly IHttpClientHelper Helper;

        public MenuCategoryDTO Model;

        public MenuCategoriesClient(HttpClient client, IHttpClientHelper helper)
        {
            Client = client;
            Helper = helper;
        }

        public async Task<IEnumerable<MenuCategoryDTO>> GetMenuCategoriesAsync()
        {
            var HttpResponse = await Client.GetAsync("api/MenuCategories");

            return await Helper.ResponseParsingListAsync<MenuCategoryDTO>(HttpResponse);
        }

        public async Task<MenuCategoryDTO> GetMenuCategoriesByIdAsync(int Id)
        {
            var HttpResponse = await Client.GetAsync($"api/MenuCategories/{Id}");

            return await Helper.ResponseParsingAsync<MenuCategoryDTO>(HttpResponse);
        }

        public async Task<MenuCategoryDTO> CreateMenuCategoryAsync(MenuCategoryDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);
            var HttpResponse = await Client.PostAsync("api/MenuCategories" , content);

            if(HttpResponse.IsSuccessStatusCode)
                Model = await Helper.ResponseParsingAsync<MenuCategoryDTO>(HttpResponse);

            return Model;
        }

        public async Task<MenuCategoryDTO> UpdateMenuCategoryAsync(MenuCategoryDTO Entity)
        {
            HttpContent content = Helper.CreateHttpContent(Entity);
            var HttpResponse = await Client.PutAsync("api/MenuCategories", content);

            if (HttpResponse.IsSuccessStatusCode)
                Model = await Helper.ResponseParsingAsync<MenuCategoryDTO>(HttpResponse);

            return Model;
        }

        public async Task DeleteMenuCategoryAsync(int Id)
        {
            await Client.DeleteAsync($"api/MenuCategories/{Id}");
        }
    }
}
