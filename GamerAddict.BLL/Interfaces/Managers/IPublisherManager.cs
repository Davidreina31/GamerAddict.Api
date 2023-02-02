using System;
using GamerAddict.Domain.Entity;

namespace GamerAddict.BLL.Interfaces.Managers
{
	public interface IPublisherManager : IBaseManager<Publisher>
	{
        Task<Publisher> GetPublisherByName(string name);
    }
}

