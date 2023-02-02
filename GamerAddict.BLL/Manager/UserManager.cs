using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class UserManager : IUserManager
	{
        private readonly IUserRepository _repo;

		public UserManager(IUserRepository repository)
		{
            _repo = repository;
		}

        public async Task<User> Add(User ItemToAdd)
        {
            var allUsers = await GetAll();

            foreach (var item in allUsers)
            {
                if (item.Sub == ItemToAdd.Sub)
                {
                    throw new Exception("User already in DB");
                }
            }
            return await _repo.Add(ItemToAdd);
        }

        public async Task<User> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<User> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<User> GetUserBySub(string sub)
        {
            return await _repo.GetUserBySub(sub);
        }

        public async Task<User> Update(User ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

