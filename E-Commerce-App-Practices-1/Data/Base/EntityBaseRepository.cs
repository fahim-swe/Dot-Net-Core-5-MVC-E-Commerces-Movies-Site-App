﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<T>> getAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();

            return result;
        }

        public async Task<T> getByIdAsync(int id)
        {
            var resutl = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return resutl;
        }


      
       
        public Task<T> UpdateAsync(int id, T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}