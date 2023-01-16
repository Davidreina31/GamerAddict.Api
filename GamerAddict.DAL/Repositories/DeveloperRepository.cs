using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class DeveloperRepository : IDeveloperRepository
	{
		public DeveloperRepository()
		{
		}

        public Task<Developer> Add(Developer ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Developer> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Developer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Developer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Developer> Update(Developer ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

