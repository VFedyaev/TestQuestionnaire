using System;
using System.Linq;

namespace Questionnaire.Data.Interfaces
{
    public interface IRepository
    {
    }

    public interface IRepository<T> : IRepository where T : class, IEntityBase, new()
    {
        IQueryable<T> GetAll();
        T GetById(Guid? id);
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
