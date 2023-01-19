using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class CommentManager : ICommentManager
	{
        private readonly ICommentRepository _repo;

		public CommentManager(ICommentRepository repo)
		{
            _repo = repo;
		}

        public async Task<Comment> Add(Comment ItemToAdd)
        {
            return await _repo.Add(ItemToAdd);
        }

        public async Task<Comment> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<Comment>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Comment> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<Comment> Update(Comment ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

