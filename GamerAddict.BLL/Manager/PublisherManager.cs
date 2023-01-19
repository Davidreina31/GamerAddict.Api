using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class PublisherManager : IPublisherManager
	{
        private readonly IPublisherRepository _repo;

		public PublisherManager(IPublisherRepository repository)
		{
            _repo = repository;
		}

        public async Task<Publisher> Add(Publisher ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Publisher> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Publisher> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Publisher> Update(Publisher ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

