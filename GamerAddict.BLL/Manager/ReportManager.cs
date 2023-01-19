using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class ReportManager : IReportManager
	{
        private readonly IReportRepository _repo;

		public ReportManager(IReportRepository repository)
		{
            _repo = repository;
		}

        public async Task<Report> Add(Report ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Report> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Report>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Report> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Report> Update(Report ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

