using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Interfaces.Services
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetBrandsByIdAsync(int Id);
        Task<IEnumerable<Brand>> GetAll();
        Task<Brand> AddBrandAsync(Brand Entity);
        Task<Brand> UpdateBrandAsync(Brand Entity);
        Task<Brand> DeleteBrandAsync(int Id);
        Task<Brand> IsActive(int Id);
    }
}
