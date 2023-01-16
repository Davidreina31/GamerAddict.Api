using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class AnswerRepository : IAnswerRepository
	{
		public AnswerRepository()
		{
		}

        public Task<Answer> Add(Answer ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Answer> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Answer> Update(Answer ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

