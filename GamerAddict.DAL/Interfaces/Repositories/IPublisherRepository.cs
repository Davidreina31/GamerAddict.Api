using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IPublisherRepository : IBaseRepository<Publisher>
	{
		Task<Publisher> GetPublisherByName(string name);
	}
}

