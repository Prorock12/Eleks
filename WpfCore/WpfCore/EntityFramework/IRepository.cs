using System;
using System.Collections.Generic;

namespace WpfCore.EntityFramework
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetElementsList();
        T GetElement(string key);
        void Create(T item);
        void Update(T item);
        void Delete(string key);
        void Save();
    }
}