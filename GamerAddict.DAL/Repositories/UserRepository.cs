using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class UserRepository : IUserRepository
	{
		public UserRepository()
		{
		}

        public Task<User> Add(User ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<User> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

