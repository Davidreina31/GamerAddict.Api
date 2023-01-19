using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class AnswerManager : IAnswerManager
	{
        private readonly IAnswerRepository _repo;

		public AnswerManager(IAnswerRepository repo)
		{
            _repo = repo;
		}

        public async Task<Answer> Add(Answer ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Answer> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Answer>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Answer> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Answer> Update(Answer ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

