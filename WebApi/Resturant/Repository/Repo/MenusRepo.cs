using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Repo;

namespace WebAPI.Repository.Repo
{
    public class MenusRepo : Repository<Menu>, IMenusRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;

        public MenusRepo(compassContext _context, IloggerManager Logger) : base(_context, Logger)
        {
            this._context = _context;
        }

        public async Task<Menu> IsArchive(int Id)
        {
            Menu Entity = _context.Menu.First(a => a.MenuId == Id);
            Entity.ArchivedDate = DateTime.Now;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}

