using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class CommentRepository : ICommentRepository
	{
        private readonly ApplicationDbContext _context;

		public CommentRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task<Comment> Add(Comment ItemToAdd)
        {
            await _context.Comments.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Comment> Delete(int id)
        {
            var item = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);
            _context.Comments.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Comment>> GetAll()
        {
            return await _context.Comments.Include(x => x.User).ToListAsync();
        }

        public async Task<Comment> GetById(int id)
        {
            var item = await _context.Comments.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public Task<Comment> Update(Comment ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

