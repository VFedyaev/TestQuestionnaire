using System;

namespace Questionnaire.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
        void SaveChanges();
        void RunInTransaction(Action action);
    }
}
