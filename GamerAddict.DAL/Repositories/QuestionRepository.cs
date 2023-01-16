using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class QuestionRepository : IQuestionRepository
	{
		public QuestionRepository()
		{
		}

        public Task<Question> Add(Question ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Question> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Question> Update(Question ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

