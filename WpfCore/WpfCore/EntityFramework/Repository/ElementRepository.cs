using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelStandard.Models;

namespace WpfCore.EntityFramework.Repository
{
    public class ElementRepository : IRepository<VisualElement>
    {
        private readonly ApplicationContext _db;
        private bool _disposed;
        public ElementRepository()
        {
            _db = new ApplicationContext();
        }

        public IEnumerable<VisualElement> GetElementsList()
        {
            return _db.VisualElements;
        }

        public VisualElement GetElement(string key)
        {
            return _db.VisualElements.Find(key);
        }

        public void Create(VisualElement item)
        {
            _db.VisualElements.Add(item);
            Save();
        }

        public void Update(VisualElement item)
        {
            _db.Entry(item).State = EntityState.Modified;
            Save();
        }

        public void Delete(string key)
        {
            var presentation = _db.VisualElements.Find(key);
            if (presentation != null)
                _db.VisualElements.Remove(presentation);
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
