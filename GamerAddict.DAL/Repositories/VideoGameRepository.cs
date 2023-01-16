using System;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Repositories
{
	public class VideoGameRepository : IVideoGameRepository
	{
		public VideoGameRepository()
		{
		}

        public Task<VideoGame> Add(VideoGame ItemToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<VideoGame> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VideoGame>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<VideoGame> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VideoGame> Update(VideoGame ItemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

