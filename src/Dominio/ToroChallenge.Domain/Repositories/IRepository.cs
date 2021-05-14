using System;
using System.Linq;

namespace ToroChallenge.Domain.Repositories
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>, IWriteRepository<TEntity> where TEntity : class
    {
    }
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity Get(Predicate<TEntity> filtro);
        IQueryable<TEntity> GetAll(Predicate<TEntity> filtro);
    }
    public interface IWriteRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
