using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class PublisherRepository : IPublisherRepository
	{
		public PublisherRepository()
		{
		}

        public Task<Publisher> Add(Publisher ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Publisher>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Update(Publisher ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

