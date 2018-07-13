using System;
using System.Collections.Generic;

namespace Nexus.DataProvider.EntityModels
{
    public class DbCustomer
    {
        public int Id { get; set; }

        public DateTime DoB { get; set; }

        public List<DbOrder> Orders { get; set; }

        public int DbUserId { get; set; }

        public virtual DbUser DbUser { get; set; }
    }
}