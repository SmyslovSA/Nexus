﻿using Nexus.DataProvider.EntityModels;
using System.Data.Entity;

namespace Nexus.DataProvider.Context
{
    public class NexusContext : DbContext
    {
        public NexusContext() : base("DefaultConnection") { }

        public DbSet<DbCustomer> DbCustomer { get; set; }

        public DbSet<DbGallery> DbGallery { get; set; }

        public DbSet<DbOrder> DbOrder { get; set; }

        public DbSet<DbProduct> DbProduct { get; set; }

        public DbSet<DbSaler> DbSaler { get; set; }

        public DbSet<DbUser> DbUser { get; set; }
    }
}