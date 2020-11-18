using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Repo
{
    public interface IMenuCategoriesRepo : IRepository<MenuCategory>
    {
        Task<MenuCategory> IsArchive(int Id);
    }
}
