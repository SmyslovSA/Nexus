using Nexus.DataProvider.Context;
using Nexus.DataProvider.EntityModels;
using Nexus.DataProvider.Interfaces;

namespace Nexus.DataProvider.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(NexusContext context) : base(context) { }
    }
}
