using Nexus.DataProvider.Context;
using Nexus.DataProvider.Interfaces;
using System.Data.Entity;

namespace Nexus.DataProvider.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly NexusContext _nexusContext;
        private readonly DbSet<TEntity> _dbset;

        public BaseRepository(NexusContext context)
        {
            _nexusContext = context;
            _dbset = _nexusContext.Set<TEntity>();

        }

        public void Delete<TKey>(TKey id)
        {
            var itemToRemove = _dbset.Find(id);
            _dbset.Remove(itemToRemove);
        }

        public void Delete(TEntity entity)
        {
            if (_nexusContext.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }

            _dbset.Remove(entity);
        }

        public TEntity GetById<TKey>(TKey id)
        {
            return _dbset.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _dbset.Attach(entity);
            _nexusContext.Entry(entity).State = EntityState.Added;
        }

        public void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _nexusContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
