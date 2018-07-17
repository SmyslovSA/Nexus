using Nexus.DataProvider.EntityModels;
using System.Data.Entity;

namespace Nexus.DataProvider.Context
{
    public class NexusContext : DbContext
    {
        public NexusContext() : base("DefaultConnection") { }

        public DbSet<Customer> DbCustomer { get; set; }

        public DbSet<Gallery> DbGallery { get; set; }

        public DbSet<Order> DbOrder { get; set; }

        public DbSet<Product> DbProduct { get; set; }

        public DbSet<Saler> DbSaler { get; set; }

        public DbSet<DbUser> DbUser { get; set; }
    }
}
