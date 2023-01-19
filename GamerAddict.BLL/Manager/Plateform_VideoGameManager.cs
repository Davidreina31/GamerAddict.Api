using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class Plateform_VideoGameManager : IPlateform_VideoGameManager
	{
        private readonly IPlateform_VideoGameRepository _repo;

		public Plateform_VideoGameManager(IPlateform_VideoGameRepository repo)
		{
            _repo = repo;
		}

        public async Task<Plateform_VideoGame> Add(Plateform_VideoGame ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Plateform_VideoGame> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Plateform_VideoGame>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Plateform_VideoGame> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Plateform_VideoGame> Update(Plateform_VideoGame ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

