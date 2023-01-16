using System;
namespace GamerAddict.DAL.Interfaces.Repositories
{
	public interface IBaseRepository<T>
	{
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Add(T ItemToAdd);

        Task<T> Update(T ItemToUpdate);

        Task<T> Delete(int id);
    }
}

