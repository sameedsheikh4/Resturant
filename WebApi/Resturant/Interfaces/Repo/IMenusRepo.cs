using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Repo
{
    public interface IMenusRepo : IRepository<Menu>
    {
        Task<Menu> IsArchive(int Id);
    }
}
