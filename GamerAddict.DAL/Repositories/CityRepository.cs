using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class CityRepository : ICityRepository
	{
		public CityRepository()
		{
		}

        public Task<City> Add(City ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<City> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<City> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<City> Update(City ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

