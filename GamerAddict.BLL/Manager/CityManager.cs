using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class CityManager : ICityManager
	{
        private readonly ICityRepository _repo;

		public CityManager(ICityRepository repo)
		{
            _repo = repo;
		}

        public async Task<City> Add(City ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<City> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<City> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<City> Update(City ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

