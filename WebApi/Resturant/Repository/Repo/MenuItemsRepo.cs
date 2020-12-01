using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Repo;

namespace WebAPI.Repository.Repo
{
    public class MenuItemsRepo : Repository<MenuItem>, IMenuItemsRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;
        public MenuItemsRepo(compassContext _context, IloggerManager Logger) : base(_context, Logger)
        {
            this._context = _context;
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItemAsync(int storeId, int? MenuId)
        {
            IEnumerable<MenuItem> Entity;

            Entity = await
            _context.MenuItem.Where(x => x.StoreId == storeId && x.ArchivedDate == null).Include(x => x.Item).ThenInclude(x => x.ItemPhoto).ToListAsync();

            if (MenuId != null)
            {
                Entity = await
                    _context.MenuItem.Where(x => x.StoreId == storeId && x.ArchivedDate == null && x.MenuId == MenuId).Include(x => x.Menu).Include(x => x.Item).ThenInclude(x => x.ItemPhoto).ToListAsync(); ;
            }            

            return Entity;
        }

        public async Task<MenuItem> IsArchive(int Id)
        {
            MenuItem Entity = _context.MenuItem.First(a => a.MenuItemId == Id);
            Entity.ArchivedBy = "sameed";
            Entity.ArchivedDate = DateTime.Now;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
