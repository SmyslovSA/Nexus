using Nexus.DataProvider.EntityModels;
using System;

namespace Nexus.DataProvider.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Gallery> GalleryRepository { get; }
        IBaseRepository<Order> OrderRepository { get; }
        IBaseRepository<Product> ProductRepository { get; }
        int SaveChanges();
    }
}
