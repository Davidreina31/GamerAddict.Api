using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class ReportRepository : IReportRepository
	{
		public ReportRepository()
		{
		}

        public Task<Report> Add(Report ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Report> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Report>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Report> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Report> Update(Report ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

