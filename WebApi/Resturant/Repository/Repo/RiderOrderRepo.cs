using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Repo;

namespace WebAPI.Repository.Repo
{
    public class RiderOrderRepo : Repository<OrderRider> , IRiderOrderRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;

        public RiderOrderRepo(compassContext context, IloggerManager Logger) : base(context, Logger)
        {
            _context = context;
            logger = Logger;
        }

        public async Task<OrderRider> IsArchive(int Id)
        {
            OrderRider Entity = _context.OrderRider.First(x => x.OrderId == Id);
            Entity.ArchivedBy = "Sameed";
            Entity.ArchivedDate = DateTime.Now;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
