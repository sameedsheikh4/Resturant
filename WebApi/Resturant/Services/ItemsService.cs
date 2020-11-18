using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class ItemsService : IItemService
    {
        protected readonly IItemsRepo _repo;
        public ItemsService(IItemsRepo repo)
        {
            _repo = repo;
        }
        public async Task<Item> AddItemAsync(Item Item)
        {
            Item.CreatedDate = DateTime.Now;
            return await _repo.AddAsync(Item);
        }

        public Task<bool> DeleteItemAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<IEnumerable<Item>> GetItemsByIdAsync(int Id)
        {
            return await _repo.GetByIdAsync(x => x.ItemId == Id && x.ArchivedDate == null, "ItemPhoto");
        }

        public async Task<Item> IsArchive(int Id)
        {
            return await _repo.IsArchive(Id);
        }

        public async Task<Item> UpdateItemAsync(Item Item)
        {
            return await _repo.UpdateAsync(Item);
        }
    }
}
