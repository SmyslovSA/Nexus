namespace Nexus.DataProvider.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity:class
    {
        TEntity GetById<TKey>(TKey id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete<TKey>(TKey id);
        void Delete(TEntity entity);
    }
}
