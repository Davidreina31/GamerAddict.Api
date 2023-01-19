using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class PlateformManager : IPlateformManager
	{
        private readonly IPlateformRepository _repo;

		public PlateformManager(IPlateformRepository repository)
		{
            _repo = repository;
		}

        public async Task<Plateform> Add(Plateform ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Plateform> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Plateform>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Plateform> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Plateform> Update(Plateform ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

