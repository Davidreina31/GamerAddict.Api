using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class VideoGameRepository : IVideoGameRepository
	{
        private readonly ApplicationDbContext _context;

        public VideoGameRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<VideoGame> Add(VideoGame ItemToAdd)
        {
            await _context.VideoGames.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<VideoGame> Delete(int id)
        {
            var item = await _context.VideoGames.FirstOrDefaultAsync(x => x.Id == id);
            _context.VideoGames.Remove(item);
            _context.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<VideoGame>> GetAll()
        {
            return await _context.VideoGames.Include(x => x.Comments).Include(x => x.Publisher)
                .Include(x => x.Developer).Include(x => x.Questions)
                .Include(x => x.PlateformVideoGame).ThenInclude(x => x.Plateform)
                .ToListAsync();
        }

        public async Task<VideoGame> GetById(int id)
        {
            var item = await _context.VideoGames.Include(x => x.Comments).Include(x => x.Publisher)
                .Include(x => x.Developer).Include(x => x.Questions).ThenInclude(x => x.Answers).Include(x => x.PlateformVideoGame).ThenInclude(x => x.Plateform).FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<VideoGame> Update(VideoGame ItemToUpdate)
        {
            var result = await _context.VideoGames.FirstOrDefaultAsync(item => item.Id == ItemToUpdate.Id);

            result = ItemToUpdate;
            _context.Update(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

