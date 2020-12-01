using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IMenuItemService
    {
        Task<IEnumerable<MenuItem>> GetMenuItemsByIdAsync(int StoreId, int MenuId);
        Task<IEnumerable<MenuItem>> GetAll();
        Task<MenuItem> AddMenuItemAsync(MenuItem Entity);
        Task<MenuItem> UpdateMenuItemAsync(MenuItem Entity);
        Task<bool> DeleteMenuItemAsync(int Id);
        Task<MenuItem> IsArchive(int Id);
        Task<IEnumerable<MenuItem>> GetDetails(int StoreId, int? MenuId);       
    }
}
