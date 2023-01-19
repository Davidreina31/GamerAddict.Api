using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class DeveloperManager : IDeveloperManager
	{
        private readonly IDeveloperRepository _repo;

		public DeveloperManager(IDeveloperRepository repo)
		{
            _repo = repo;
		}

        public async Task<Developer> Add(Developer ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Developer> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Developer>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Developer> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Developer> Update(Developer ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

