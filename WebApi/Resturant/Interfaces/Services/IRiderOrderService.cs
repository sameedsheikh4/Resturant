using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IRiderOrderService
    {
        Task<OrderRider> AssignOrderToRiderAsync(OrderRider Entity);
        Task<IEnumerable<OrderRider>> GetOrderByIdAsync(int OrderId);
        Task<OrderRider> UpdateDeliveryInfoAsync(OrderRider Entity);
        Task<OrderRider> IsArchive(int Id);
    }
}
