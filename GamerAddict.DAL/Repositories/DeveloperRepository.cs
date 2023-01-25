using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class DeveloperRepository : IDeveloperRepository
	{
        private readonly ApplicationDbContext _context;

        public DeveloperRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Developer> Add(Developer ItemToAdd)
        {
            await _context.Developers.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Developer> Delete(int id)
        {
            var item = await _context.Developers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Developer>> GetAll()
        {
            return await _context.Developers.ToListAsync();
        }

        public async Task<Developer> GetById(int id)
        {
            var item = await _context.Developers.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public Task<Developer> Update(Developer ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

