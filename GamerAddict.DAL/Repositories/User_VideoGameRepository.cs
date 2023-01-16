using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class User_VideoGameRepository : IUser_VideoGameRepository
	{
		public User_VideoGameRepository()
		{
		}

        public Task<User_VideoGame> Add(User_VideoGame ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<User_VideoGame> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_VideoGame>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User_VideoGame> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User_VideoGame> Update(User_VideoGame ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

