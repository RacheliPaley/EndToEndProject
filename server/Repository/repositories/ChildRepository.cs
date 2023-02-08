using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Repository.entities;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.repositories
{
    public class ChildRepository : IDataRepository<Child>
    {
        Icontext _context;
        public ChildRepository(Icontext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> newOne = _context.ChildsContext.Add(entity);

            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.ChildsContext.Remove(_context.ChildsContext.FirstOrDefault(p => p.Id == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.ChildsContext.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.ChildsContext.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            var newEntity = _context.ChildsContext.Update(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }
    }
}
