using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class Plateform_VideoGameRepository : IPlateform_VideoGameRepository
	{
        private readonly ApplicationDbContext _context;

        public Plateform_VideoGameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Plateform_VideoGame> Add(Plateform_VideoGame ItemToAdd)
        {
            await _context.Plateform_VideoGames.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Plateform_VideoGame> Delete(int id)
        {
            var item = await _context.Plateform_VideoGames.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Plateform_VideoGame>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Plateform_VideoGame>> GetAllForVideoGameId(int id)
        {
            return await _context.Plateform_VideoGames.Where(x => x.VideoGameId == id).ToListAsync();
        }

        public async Task<Plateform_VideoGame> GetById(int id)
        {
            var item = await _context.Plateform_VideoGames.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public Task<Plateform_VideoGame> Update(Plateform_VideoGame ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

