using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PresentationWebApplication.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext _db;
        private bool _disposed;

        protected BaseRepository(DatabaseContext context)
        {
            _db = context;
        }

        public async Task CreateAsync(T item)
        {
            await _db.Set<T>().AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(T item, int id)
        {
            var message = await _db.Set<T>().FindAsync(id);
            if (message != null)
                _db.Set<T>().Remove(message);
        }

        public async Task<T> GetElementAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetElementsListAsync()
        {
            return await _db.Set<T>().ToArrayAsync();
        }

        public void Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}