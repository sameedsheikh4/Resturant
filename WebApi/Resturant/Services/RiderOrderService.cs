using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class RiderOrderService : IRiderOrderService
    {
        private readonly IRiderOrderRepo _repo;
        public RiderOrderService(IRiderOrderRepo repo)
        {
            _repo = repo;
        }
        public async Task<OrderRider> AssignOrderToRiderAsync(OrderRider Entity)
        {
            Entity.CreatedDate = DateTime.Now;
            return await _repo.AddAsync(Entity);
        }

        public async Task<IEnumerable<OrderRider>> GetOrderByIdAsync(int OrderId)
        {
            return await _repo.GetByIdAsync(x => x.OrderId == OrderId, null);
        }

        public async Task<OrderRider> IsArchive(int Id)
        {
            return await _repo.IsArchive(Id);
        }

        public async Task<OrderRider> UpdateDeliveryInfoAsync(OrderRider Entity)
        {
            Entity.ArchivedDate = DateTime.Now;
            return await _repo.UpdateAsync(Entity);
        }
    }
}
