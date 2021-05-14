using System;
using System.Linq;
using ToroChallenge.Domain.Repositories;

namespace ToroChallenge.Data
{
    public class Repository<TEntity> : WriteRepository<TEntity>, IRepository<TEntity> where TEntity : class
    {
    }
    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        public TEntity Get(Predicate<TEntity> filtro)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll(Predicate<TEntity> filtro)
        {
            throw new NotImplementedException();
        }
    }
    public class WriteRepository<TEntity> : ReadOnlyRepository<TEntity>, IWriteRepository<TEntity> where TEntity : class
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
