using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Data.Interfaces;

namespace Questionnaire.Data.Patterns
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual T GetById(Guid? id)
        {
            return _context.Find<T>(id);
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void Delete(Guid id)
        {
            T entity = _context.Find<T>(id);
            if (entity != null)
                _context.Remove(entity);
        }
    }
}
