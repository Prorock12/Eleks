using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ModelStandard.Models;

namespace WpfCore.EntityFramework.Repository
{
    public class SlideRepository : IRepository<Slide>
    {
        private readonly ApplicationContext _db;
        private bool _disposed;
        public SlideRepository()
        {
            _db = new ApplicationContext();
        }

        public IEnumerable<Slide> GetElementsList()
        {
            return _db.Slides;
        }

        public Slide GetElement(string id)
        {
            return _db.Slides.Find(id);
        }

        public void Create(Slide item)
        {
            _db.Slides.Add(item);
            Save();
        }

        public void Update(Slide item)
        {
            _db.Entry(item).State = EntityState.Modified;
            Save();
        }

        public void Delete(string id)
        {
            var presentation = _db.Slides.Find(id);
            if (presentation != null)
                _db.Slides.Remove(presentation);
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
