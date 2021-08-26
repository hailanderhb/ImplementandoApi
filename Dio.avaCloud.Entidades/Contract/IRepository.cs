using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dio.avaCloud.Entidades.Contract
{
    public interface IRepository <T> where T:EntityBase
    {
        Task<int> AddAsync(T entity);
        Task EditAsync(T entity);
        Task DeleteAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<int> CountAsync();


    }
}
