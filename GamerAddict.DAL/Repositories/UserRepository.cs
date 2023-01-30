using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class UserRepository : IUserRepository
	{
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> Add(User ItemToAdd)
        {
            var allUsers = await GetAll();

            foreach (var item in allUsers)
            {
                if (item.Sub == ItemToAdd.Sub)
                {
                    throw new Exception("User already in DB");
                }
            }
            await _context.Users.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();

            return ItemToAdd;
        }

        public async Task<User> Delete(int id)
        {
            var item = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            _context.Users.Remove(item);

            return item;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            var item = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<User> GetUserBySub(string sub)
        {
            var result = await _context.Users.FirstOrDefaultAsync(item => item.Sub == sub);

            return result;
        }

        public async Task<User> Update(User ItemToUpdate)
        {
            var result = await _context.Users.FirstOrDefaultAsync(item => item.Id == ItemToUpdate.Id);

            result = ItemToUpdate;
            _context.Update(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

