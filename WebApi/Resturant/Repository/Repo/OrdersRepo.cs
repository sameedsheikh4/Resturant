using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Repo;

namespace WebAPI.Repository.Repo
{
    public class OrdersRepo : Repository<StoreOrder>, IOrdersRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;

        public OrdersRepo(compassContext context, IloggerManager Logger):base(context,Logger)
        {
            _context = context;
            logger = Logger;
        }

        public Task<StoreOrder> AssignOrderToRider(int OrderId, int RiderId)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderStatus> StatusFlag(int OrderId, int StatusId)
        {
            OrderStatus Entity = _context.OrderStatus.First(a => a.OrderId == OrderId);
            Entity.StatusId = StatusId;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }

        public async Task<StoreOrder> IsArchive(int Id)
        {
            StoreOrder Entity = _context.StoreOrder.First(a => a.OrderId == Id);
            Entity.ArchivedBy = "sameed";
            Entity.ArchivedDate = DateTime.Now;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
