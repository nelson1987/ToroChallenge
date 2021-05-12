using System;

namespace ToroChallenge.Repository
{
    public class ContaCorrenteRepository : IRepository<object>
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetByFilter()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class RepositoryMySql<TEntity> : IRepositoryMySql<Object>
    {
        public void Update()
        {
        }
        public void Delete()
        {
        }
    }

    public class RepositoryMongo<TEntity> : IRepositoryMongo<Object>
    {
        public void GetByFilter()
        {
        }
        public void Insert()
        {
        }
    }
}
