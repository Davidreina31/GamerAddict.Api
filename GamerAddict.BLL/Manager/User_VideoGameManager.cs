using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class User_VideoGameManager : IUser_VideoGameManager
	{
        private readonly IUser_VideoGameRepository _repo;

		public User_VideoGameManager(IUser_VideoGameRepository repository)
		{
            _repo = repository;
		}

        public async Task<User_VideoGame> Add(User_VideoGame ItemToAdd)
        {
            var allForUser = await GetAll(ItemToAdd.UserId);

            foreach (var item in allForUser)
            {
                if(item.VideoGameId == ItemToAdd.VideoGameId)
                {
                    throw new Exception("Video game already added to favorites.");
                }
            }
            return await _repo.Add(ItemToAdd);
        }

        public async Task<User_VideoGame> DeleteUserVideoGame(int userId, int videoGameId)
        {
            return await _repo.DeleteUserVideoGame(userId, videoGameId);
        }

        public async Task<IEnumerable<User_VideoGame>> GetAll(int userId)
        {
            return await _repo.GetAll(userId);
        }
    }
}

