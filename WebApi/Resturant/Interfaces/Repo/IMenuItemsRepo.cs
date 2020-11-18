using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Repo
{
    public interface IMenuItemsRepo : IRepository<MenuItem>
    {
        Task<MenuItem> IsArchive(int Id);
    }
}
