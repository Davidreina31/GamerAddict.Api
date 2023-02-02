using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class PublisherRepository : IPublisherRepository
	{
        private readonly ApplicationDbContext _context;

        public PublisherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Publisher> Add(Publisher ItemToAdd)
        {
            await _context.Publishers.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Publisher> Delete(int id)
        {
            var item = await _context.Publishers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Publishers.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _context.Publishers.ToListAsync();
        }

        public async Task<Publisher> GetById(int id)
        {
            var item = await _context.Publishers.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<Publisher> GetPublisherByName(string name)
        {
            var item = await _context.Publishers.FirstOrDefaultAsync(x => x.Name == name);
            return item;
        }

        public Task<Publisher> Update(Publisher ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

