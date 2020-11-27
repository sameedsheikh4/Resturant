using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class MenuCategoryService : IMenuCategoryService
    {
        private readonly IMenuCategoriesRepo _repo;
        public MenuCategoryService(IMenuCategoriesRepo repo)
        {
            _repo = repo;
        }

        public async Task<MenuCategory> AddMenuCategoryAsync(MenuCategory MenuCategory)
        {
            MenuCategory.CreatedDate = DateTime.Now;
            return await _repo.AddAsync(MenuCategory);
        }

        public Task<bool> DeleteMenuCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MenuCategory>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<IEnumerable<MenuCategory>> GetMenuCategoriesByIdAsync(int StoreId)
        {
            return await _repo.GetByIdAsync(x => x.StoreId == StoreId && x.ArchivedDate == null, null);
        }

        public async Task<MenuCategory> IsArchive(int Id)
        {
            return await _repo.IsArchive(Id);
        }

        public async Task<MenuCategory> UpdateMenuCategoryAsync(MenuCategory MenuCategory)
        {
            return await _repo.UpdateAsync(MenuCategory);
        }
    }
}
