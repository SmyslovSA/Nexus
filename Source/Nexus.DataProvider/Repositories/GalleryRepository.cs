using Nexus.DataProvider.Context;
using Nexus.DataProvider.EntityModels;
using Nexus.DataProvider.Interfaces;

namespace Nexus.DataProvider.Repositories
{
    public class GalleryRepository : BaseRepository<Gallery>, IGalleryRepository
    {
        public GalleryRepository(NexusContext context) : base(context) { }
    }
}
