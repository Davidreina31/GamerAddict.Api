using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Interfaces.Managers
{
	public interface IPlateform_VideoGameManager : IBaseManager<Plateform_VideoGame>
	{
        Task<IEnumerable<Plateform_VideoGame>> GetAllForVideoGameId(int id);
    }
}

