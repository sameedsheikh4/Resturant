using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Repo;

namespace WebAPI.Repository.Repo
{
    public class ItemsRepo : Repository<Item>, IItemsRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;
        public ItemsRepo(compassContext _context, IloggerManager Logger) : base(_context, Logger)
        {
            this._context = _context;
        }
        public async Task<Item> IsArchive(int Id)
        {
            Item Entity = _context.Item.First(a => a.ItemId == Id);
            Entity.ArchivedBy = "sameed";
            Entity.ArchivedDate = DateTime.Now;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
