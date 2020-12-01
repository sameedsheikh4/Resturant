using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Repo
{
    public interface IRiderOrderRepo : IRepository<OrderRider>
    {
        Task<OrderRider> IsArchive(int Id);
    }
}
