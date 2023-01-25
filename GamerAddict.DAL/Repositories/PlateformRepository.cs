using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class PlateformRepository : IPlateformRepository
	{
        private readonly ApplicationDbContext _context;

        public PlateformRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Plateform> Add(Plateform ItemToAdd)
        {
            await _context.Plateforms.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Plateform> Delete(int id)
        {
            var item = await _context.Plateforms.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Plateform>> GetAll()
        {
            return await _context.Plateforms.ToListAsync();
        }

        public async Task<Plateform> GetById(int id)
        {
            var item = await _context.Plateforms.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public Task<Plateform> Update(Plateform ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

