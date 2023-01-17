using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IUser_VideoGameRepository
	{
        Task<IEnumerable<User_VideoGame>> GetAll(int userId);

        Task<User_VideoGame> Add(User_VideoGame ItemToAdd);

        Task<User_VideoGame> DeleteUserVideoGame(int userId, int videoGameId);

    }
}

