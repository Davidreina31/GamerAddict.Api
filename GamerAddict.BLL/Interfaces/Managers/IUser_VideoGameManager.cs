using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Interfaces.Managers
{
	public interface IUser_VideoGameManager
	{
        Task<IEnumerable<User_VideoGame>> GetAll(int userId);

        Task<User_VideoGame> Add(User_VideoGame ItemToAdd);

        Task<User_VideoGame> DeleteUserVideoGame(int userId, int videoGameId);
    }
}

