using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IMenusService
    {
        Task<IEnumerable<Menu>> GetMenusByIdAsync(int StoreId);
        Task<IEnumerable<Menu>> GetAll();
        Task<Menu> AddMenuAsync(Menu Entity);
        Task<Menu> UpdateMenuAsync(Menu Entity);
        Task<bool> DeleteMenuAsync(int Id);
        Task<Menu> IsArchive(int Id);
    }
}
