using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class Plateform_VideoGameRepository : IPlateform_VideoGameRepository
	{
		public Plateform_VideoGameRepository()
		{
		}

        public Task<Plateform_VideoGame> Add(Plateform_VideoGame ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Plateform_VideoGame> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Plateform_VideoGame>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Plateform_VideoGame> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Plateform_VideoGame> Update(Plateform_VideoGame ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

