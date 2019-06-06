using Moq;
using Questionnaire.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Service.Tests.MoqRepositories
{
    public class MoqBaseRepository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        public Mock<IRepository<T>> repository;
        public List<T> Items { get; }

        public MoqBaseRepository(List<T> items)
        {
            repository = new Mock<IRepository<T>>();
            Items = items;

            repository
                .Setup(x => x.Insert(It.IsAny<T>()))
                .Callback<T>(Insert);
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public T GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }


        public Task InsertAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
