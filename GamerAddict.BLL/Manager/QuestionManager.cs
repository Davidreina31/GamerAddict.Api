using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class QuestionManager : IQuestionManager
	{
        private readonly IQuestionRepository _repo;

		public QuestionManager(IQuestionRepository repository)
		{
            _repo = repository;
		}

        public async Task<Question> Add(Question ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Question> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Question>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Question>> GetAllForOneVideoGame(int id)
        {
            return await _repo.GetAllForOneVideoGame(id);
        }

        public async Task<Question> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Question> Update(Question ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

