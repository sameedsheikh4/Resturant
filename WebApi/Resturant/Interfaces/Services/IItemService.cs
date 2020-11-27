using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItemsByIdAsync(int StoreId);
        Task<IEnumerable<Item>> GetAllAsync();
        Task<Item> AddItemAsync(Item Entity);
        Task<Item> UpdateItemAsync(Item Entity);
        Task<bool> DeleteItemAsync(int Id);
        Task<Item> IsArchive(int Id);
    }
}
