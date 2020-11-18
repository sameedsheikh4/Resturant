using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Interfaces;

namespace WebAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly compassContext _context;
        private readonly IloggerManager logger;

        public Repository(compassContext context, IloggerManager Logger)
        {
            _context = context;
            logger = Logger;
        }
        public async Task<T> AddAsync(T Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} Entity must not be null");
            }

            try
            {
                await _context.AddAsync(Entity);
                await _context.SaveChangesAsync();

                return Entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(Entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool chk;

            try
            {
                var Entity = await _context.Set<T>().FindAsync(id);
                if (Entity != null)
                {
                    _context.Set<T>().Remove(Entity);
                    await _context.SaveChangesAsync();
                    chk = true;
                    return chk;
                }
                else
                {
                    throw new ArgumentNullException($"{nameof(DeleteAsync)} Entity must not be null");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(id)} could not be updated: {ex.Message}");
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByIdAsync(Expression<Func<T, bool>> Expression, string ChildObjects)
        {          
            try
            {
                var result = _context.Set<T>().Where(Expression);

                if (ChildObjects != null)
                    result.Include(ChildObjects);

                return await result.ToListAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<T> UpdateAsync(T Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException($"{nameof(UpdateAsync)} Entity must not be null");
            }

            try
            {
                _context.Update(Entity);
                await _context.SaveChangesAsync();

                return Entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(Entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
