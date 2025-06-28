using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAysnc();
        Task<T> GetAysncById(int id);
        Task<T> AddAysnc(T entity);
        Task DeleteAysnc(T entity);
        Task UpdateAysnc(T entity);



    }
}
