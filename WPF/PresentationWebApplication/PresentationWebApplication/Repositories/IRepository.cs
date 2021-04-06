using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PresentationWebApplication.Repositories
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task<IEnumerable<T>> GetElementsListAsync();
        Task<T> GetElementAsync(int id);
        Task CreateAsync(T item);
        void Update(T item);
        Task DeleteAsync(T item,int id);
    }
}