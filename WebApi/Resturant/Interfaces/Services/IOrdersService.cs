using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<StoreOrder>> GetOrdersByIdAsync(int Id);
        Task<IEnumerable<StoreOrder>> GetAllAsync();
        Task<StoreOrder> AddOrderAsync(StoreOrder Entity);
        Task<StoreOrder> UpdateOrderAsync(StoreOrder Entity);
        Task<StoreOrder> IsArchive(int Id);
        Task<OrderStatus> OrderStatusFlag(int OrderId, int StatusId);
        Task<StoreOrder> AssignOrderToRider(int OrderId, int RiderId);
    }
}
