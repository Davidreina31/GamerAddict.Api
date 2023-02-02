using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Interfaces.Managers
{
	public interface IQuestionManager : IBaseManager<Question>
	{
        Task<IEnumerable<Question>> GetAllForOneVideoGame(int id);
    }
}

