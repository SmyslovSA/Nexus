using Nexus.DataProvider.Context;
using Nexus.DataProvider.Interfaces;
using System;

namespace Nexus.DataProvider.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(NexusContext context) { }

        public void Delete<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById<TKey>(TKey id)
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
