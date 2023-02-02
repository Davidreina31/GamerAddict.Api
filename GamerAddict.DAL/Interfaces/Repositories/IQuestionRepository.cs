using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IQuestionRepository : IBaseRepository<Question>
	{
		Task<IEnumerable<Question>> GetAllForOneVideoGame(int id);
	}
}

