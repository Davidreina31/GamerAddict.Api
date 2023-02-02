using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using GamerAddict.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class AnswerRepository : IAnswerRepository
	{
        private readonly ApplicationDbContext _context;

        public AnswerRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<Answer> Add(Answer ItemToAdd)
        {
            await _context.Answers.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Answer> Delete(int id)
        {
            var item = await _context.Answers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Answer>> GetAll()
        {
            return await _context.Answers.Include(x => x.User).ToListAsync();
        }

        public async Task<Answer> GetById(int id)
        {
            var item = await _context.Answers.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<Answer> Update(Answer ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

