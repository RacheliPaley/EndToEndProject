using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.entities;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.repositories
{
    public class UserRepository : IDataRepository<User>
    {
        Icontext _context;
        public UserRepository(Icontext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User entity)
        {
            EntityEntry<User> newOne = _context.UserContext.Add(entity);

            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.     UserContext.Remove(_context.UserContext.FirstOrDefault(p => p.Id == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context. UserContext.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.     UserContext.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            var newEntity = _context.     UserContext.Update(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }
    }
}
