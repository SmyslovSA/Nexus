using System;

namespace Nexus.DataProvider.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGalleryRepository GalleryRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        int SaveChanges();
    }
}
