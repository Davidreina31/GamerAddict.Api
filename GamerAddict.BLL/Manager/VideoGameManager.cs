using System;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Manager
{
	public class VideoGameManager : IVideoGameManager
	{
        private readonly IVideoGameRepository _repo;
        private readonly IDeveloperRepository _devRepo;
        private readonly IPublisherRepository _publisherRepo;

        public VideoGameManager(IVideoGameRepository repository, IDeveloperRepository developerRepository, IPublisherRepository publisherRepository)
		{
            _repo = repository;
            _devRepo = developerRepository;
            _publisherRepo = publisherRepository;
		}

        public async Task<VideoGame> Add(VideoGame ItemToAdd)
        {
            //var developer = await _devRepo.
            return await _repo.Add(ItemToAdd);
        }

        public async Task<VideoGame> Delete(int id)
        {
            return await _repo.Delete(id);
        }

        public async Task<IEnumerable<VideoGame>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<VideoGame> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task<VideoGame> Update(VideoGame ItemToUpdate)
        {
            return await _repo.Update(ItemToUpdate);
        }
    }
}

