using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Interfaces.Managers
{
	public interface IDeveloperManager : IBaseManager<Developer>
	{
		Task<Developer> GetDeveloperByName(string name);
	}
}

