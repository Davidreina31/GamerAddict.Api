using System;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamerAddict.DAL.Repositories
{
	public class ReportRepository : IReportRepository
	{
        private readonly ApplicationDbContext _context;

        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Report> Add(Report ItemToAdd)
        {
            await _context.Reports.AddAsync(ItemToAdd);
            await _context.SaveChangesAsync();
            return ItemToAdd;
        }

        public async Task<Report> Delete(int id)
        {
            var item = await _context.Reports.FirstOrDefaultAsync(x => x.Id == id);
            _context.Reports.Remove(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<IEnumerable<Report>> GetAll()
        {
            return await _context.Reports.Include(x => x.ReporterUser).Include(x => x.Comment).ThenInclude(x => x.User)
                .Include(x => x.Comment).ThenInclude(x => x.VideoGame).ToListAsync();
        }

        public async Task<Report> GetById(int id)
        {
            var item = await _context.Reports.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public Task<Report> Update(Report ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

