using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Data.Interfaces;

namespace Questionnaire.Data.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly IDictionary<string, IRepository> _repositories;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            _repositories = new SortedDictionary<string, IRepository>();
        }

        public IRepository<T> GetRepository<T>() where T : class, IEntityBase, new()
        {
            var typeName = typeof(T).FullName;
            if (!_repositories.ContainsKey(typeName))
            {
                _repositories.Add(typeName, new Repository<T>(_context));
            }
            return (IRepository<T>)_repositories[typeName];
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void RunInTransaction(Action action)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                action.Invoke();
                transaction.Commit();
            }
        }
    }
}
