using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class OrdersService : IOrdersService
    {
        protected readonly IOrdersRepo _repo;
        public OrdersService(IOrdersRepo repo)
        {
            _repo = repo;
        }
        public Task<StoreOrder> AddOrderAsync(StoreOrder Entity)
        {
            Entity.CreatedDate = DateTime.Now;
            return _repo.AddAsync(Entity);
        }

        public Task<StoreOrder> AssignOrderToRider(int OrderId, int RiderId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StoreOrder>> GetAllAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<IEnumerable<StoreOrder>> GetOrdersByIdAsync(int StoreId)
        {
            return _repo.GetByIdAsync(x => x.StoreId == StoreId && x.ArchivedDate == null, null);
        }

        public Task<StoreOrder> IsArchive(int Id)
        {
            return _repo.IsArchive(Id);
        }

        public Task<OrderStatus> OrderStatusFlag(int OrderId, int StatusId)
        {
            return _repo.StatusFlag(OrderId, StatusId);
        }

        public Task<StoreOrder> UpdateOrderAsync(StoreOrder Entity)
        {
            Entity.ModifiedDate = DateTime.Now;
            return _repo.UpdateAsync(Entity);
        }
    }
}
