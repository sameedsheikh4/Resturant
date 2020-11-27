using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class MenusService : IMenusService
    {
        public IMenusRepo _repo;
        public MenusService(IMenusRepo repo)
        {
            _repo = repo;
        }

        public async Task<Menu> AddMenuAsync(Menu Menu)
        {
            Menu.CreatedDate = DateTime.Now;
            return await _repo.AddAsync(Menu);
        }

        public Task<bool> DeleteMenuAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Menu>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<IEnumerable<Menu>> GetMenusByIdAsync(int Id)
        {
            return await _repo.GetByIdAsync(x => x.StoreId == Id && x.ArchivedDate == null, null);
        }

        public async Task<Menu> IsArchive(int Id)
        {
            return await _repo.IsArchive(Id);
        }

        public async Task<Menu> UpdateMenuAsync(Menu Menu)
        {
            return await _repo.UpdateAsync(Menu);
        }
    }
}
