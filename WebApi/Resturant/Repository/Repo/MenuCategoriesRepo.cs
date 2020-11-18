using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Repo;

namespace WebAPI.Repository.Repo
{
    public class MenuCategoriesRepo : Repository<MenuCategory> , IMenuCategoriesRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;

        public MenuCategoriesRepo(compassContext context, IloggerManager logger) : base(context, logger)
        {
        }

        public async Task<MenuCategory> IsArchive(int Id)
        {
            MenuCategory Entity = _context.MenuCategory.First(a => a.MenuCategoryId == Id);
            Entity.ArchivedBy = "sameed";
            Entity.ArchivedDate = DateTime.Now;            
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
