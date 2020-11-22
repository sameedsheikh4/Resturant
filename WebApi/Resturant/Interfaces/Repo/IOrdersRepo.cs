using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Repo
{
    public interface IOrdersRepo : IRepository<StoreOrder>
    {
        Task<OrderStatus> StatusFlag(int OrderId, int StatusId);
        Task<StoreOrder> AssignOrderToRider(int OrderId, int RiderId);
        Task<StoreOrder> IsArchive(int Id);
    }
}
