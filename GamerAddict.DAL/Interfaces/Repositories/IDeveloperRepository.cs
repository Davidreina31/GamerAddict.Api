using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IDeveloperRepository : IBaseRepository<Developer>
	{
        Task<Developer> GetDeveloperByName(string name);
    }
}

