using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class User_VideoGameRepository : IUser_VideoGameRepository
	{
        private readonly ApplicationDbContext _context;

        public User_VideoGameRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<User_VideoGame> Add(User_VideoGame ItemToAdd)
        {
            await _context.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<User_VideoGame> Delete(int id)
        {
            var result = await _context.User_VideoGames.FirstOrDefaultAsync(item => item.Id == id);
            _context.User_VideoGames.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<User_VideoGame> DeleteUserVideoGame(int userId, int videoGameId)
        {
            var result = await _context.User_VideoGames.FirstOrDefaultAsync(item => item.UserId == userId
            && item.VideoGameId == videoGameId);

            _context.User_VideoGames.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<User_VideoGame>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User_VideoGame>> GetAll(int userId)
        {
            return await _context.User_VideoGames.Where(item => item.UserId == userId).ToListAsync();
        }

        public Task<User_VideoGame> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User_VideoGame> Update(User_VideoGame ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

