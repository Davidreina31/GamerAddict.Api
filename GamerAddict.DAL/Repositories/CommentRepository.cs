using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class CommentRepository : ICommentRepository
	{
		public CommentRepository()
		{
		}

        public Task<Comment> Add(Comment ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> Update(Comment ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

