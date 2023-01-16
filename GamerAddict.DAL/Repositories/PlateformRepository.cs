using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class PlateformRepository : IPlateformRepository
	{
		public PlateformRepository()
		{
		}

        public Task<Plateform> Add(Plateform ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Plateform> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Plateform>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Plateform> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Plateform> Update(Plateform ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

