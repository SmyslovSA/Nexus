using Nexus.DataProvider.Context;
using Nexus.DataProvider.EntityModels;
using Nexus.DataProvider.Interfaces;
using System;

namespace Nexus.DataProvider.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private NexusContext _nexusContext;

        public UnitOfWork(
            NexusContext context,
            IBaseRepository<Gallery> galleryRepository,
            IBaseRepository<Order> orderRepository,
            IBaseRepository<Product> productRepository)
        {
            _nexusContext = context;
            GalleryRepository = galleryRepository;
            OrderRepository = orderRepository;
            ProductRepository = productRepository;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        public IBaseRepository<Gallery> GalleryRepository { get; }

        public IBaseRepository<Order> OrderRepository { get; }

        public IBaseRepository<Product> ProductRepository { get; }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            {
                if (_disposed) return;

                if (disposing)
                {
                    GC.SuppressFinalize(this);
                }

                _nexusContext?.Dispose();
                _nexusContext = null;
                _disposed = true;
            }
        }

        public int SaveChanges()
        {
           return _nexusContext.SaveChanges();
        }
    }
}
