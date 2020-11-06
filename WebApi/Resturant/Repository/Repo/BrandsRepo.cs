using Common.logger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Client;

namespace WebAPI.Repository.Client
{
    public class BrandsRepo : Repository<Brand> , IBrandsRepo
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;
        public BrandsRepo(compassContext _context, IloggerManager Logger) : base(_context, Logger)
        {
            this._context = _context;
        }

        public async Task<Brand> IsActive(int Id)
        {
            Brand Entity = _context.Brand.First(a => a.BrandId == Id);
            Entity.IsActive = true;
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
