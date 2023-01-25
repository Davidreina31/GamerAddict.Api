using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class CityRepository : ICityRepository
	{
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<City> Add(City ItemToAdd)
        {
            await _context.Cities.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<City> Delete(int id)
        {
            var item = await _context.Cities.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetById(int id)
        {
            var item = await _context.Cities.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<City> Update(City ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

