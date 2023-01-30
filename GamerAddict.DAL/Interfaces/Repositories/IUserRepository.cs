using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IUserRepository : IBaseRepository<User>
	{
        Task<User> GetUserBySub(string sub);

    }
}

