using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IMenuCategoryService
    {
        Task<IEnumerable<MenuCategory>> GetMenuCategoriesByIdAsync(int Id);
        Task<IEnumerable<MenuCategory>> GetAll();
        Task<MenuCategory> AddMenuCategoryAsync(MenuCategory Entity);
        Task<MenuCategory> UpdateMenuCategoryAsync(MenuCategory Entity);
        Task<bool> DeleteMenuCategoryAsync(int Id);
        Task<MenuCategory> IsArchive(int Id);
    }
}
