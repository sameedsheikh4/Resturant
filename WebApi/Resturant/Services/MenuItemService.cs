using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class MenuItemService : IMenuItemService
    {
        protected readonly IMenuItemsRepo _repo;

        public MenuItemService(IMenuItemsRepo repo)
        {
            _repo = repo;
        }
        public async Task<MenuItem> AddMenuItemAsync(MenuItem Entity)
        {
            Entity.CreatedDate = DateTime.Now;
            return await _repo.AddAsync(Entity);
        }

        public Task<bool> DeleteMenuItemAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MenuItem>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItemsByIdAsync(int Id)
        {
            return await _repo.GetByIdAsync(x => x.MenuItemId == Id, null);
        }

        public async Task<MenuItem> IsArchive(int Id)
        {
            return await _repo.IsArchive(Id);
        }

        public Task<MenuItem> UpdateMenuItemAsync(MenuItem Entity)
        {
            Entity.ModifiedDate = DateTime.Now;
            return _repo.UpdateAsync(Entity);
        }
    }
}
