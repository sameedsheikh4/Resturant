using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces.Client;
using WebAPI.Interfaces.Services;

namespace WebAPI.Services
{
    public class BrandsService : IBrandService
    {
        protected readonly IBrandsRepo _brandsRepo;
        public BrandsService(IBrandsRepo brandsRepo)
        {
            _brandsRepo = brandsRepo;
        }
        public async Task<Brand> AddBrandAsync(Brand brand)
        {
            brand.CreatedDate = DateTime.Now;
            return await _brandsRepo.AddAsync(brand);
        }

        public async Task<Brand> DeleteBrandAsync(int id)
        {
            return await _brandsRepo.Archive(id);
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            return await _brandsRepo.GetAllAsync();
        }

        public async Task<IEnumerable<Brand>> GetBrandsByIdAsync(int id)
        {
            return await _brandsRepo.GetByIdAsync(x => x.BrandId == id, null);
        }

        public async Task<Brand> IsActive(int Id)
        {
            return await _brandsRepo.IsActive(Id);
        }

        public async Task<Brand> UpdateBrandAsync(Brand brand)
        {
            return await _brandsRepo.UpdateAsync(brand);
        }
    }
}
