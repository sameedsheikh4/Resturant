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
        public async Task<Item> AddItemAsync(Item Entity)
        {
            Entity.CreatedDate = DateTime.Now;
            return await _repo.AddAsync(Entity);
        }

        public Task<bool> DeleteItemAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<IEnumerable<Item>> GetItemsByIdAsync(int StoreId)
        {
            return await _repo.GetByIdAsync(x => x.StoreId == StoreId && x.ArchivedDate == null, null);
        }

        public async Task<Item> IsArchive(int Id)
        {
            return await _repo.Archive(Id);
        }

        public async Task<Item> UpdateItemAsync(Item Entity)
        {
            return await _repo.UpdateAsync(Entity);
        }
    }
}
