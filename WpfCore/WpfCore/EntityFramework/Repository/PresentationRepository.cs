using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelStandard.Models;

namespace WpfCore.EntityFramework.Repository
{
    public class PresentationRepository : IRepository<Presentation>
    {
        private readonly ApplicationContext _db;
        private bool _disposed;
        public PresentationRepository()
        {
            _db = new ApplicationContext();
        }

        public IEnumerable<Presentation> GetElementsList()
        {
            return _db.Presentations;
        }

        public Presentation GetElement(string key)
        {
            return _db.Presentations.Find(key);
        }

        public void Create(Presentation item)
        {
            _db.Presentations.Add(item);
            Save();
        }

        public void Update(Presentation item)
        {
            _db.Entry(item).State = EntityState.Modified;
            Save();
        }

        public void Delete(string key)
        {
            var presentation = _db.Presentations.Find(key);
            if (presentation != null)
                _db.Presentations.Remove(presentation);
            Save();
        }

        public void Save()
        {
            _db.SaveChanges();
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
