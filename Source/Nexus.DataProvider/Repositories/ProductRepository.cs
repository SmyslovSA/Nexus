using Nexus.DataProvider.Context;
using Nexus.DataProvider.EntityModels;
using Nexus.DataProvider.Interfaces;

namespace Nexus.DataProvider.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(NexusContext context) : base(context) { }
    }
}
