using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IPlateform_VideoGameRepository : IBaseRepository<Plateform_VideoGame>
	{
		Task<IEnumerable<Plateform_VideoGame>> GetAllForVideoGameId(int id);
	}
}

