using System;
namespace GamerAddict.BLL.Interfaces.Managers
{
	public interface IBaseManager <T>
	{
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Add(T ItemToAdd);

        Task<T> Update(T ItemToUpdate);

        Task<T> Delete(int id);
    }
}

