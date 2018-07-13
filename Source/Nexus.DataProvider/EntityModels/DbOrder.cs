using System;
using System.Collections.Generic;

namespace Nexus.DataProvider.EntityModels
{
    public class DbOrder
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Count { get; set; }

        public int OrderNumber { get; set; }

        public List<DbProduct> Products { get; set; }

        public int DbCustomerId { get; set; }

        public virtual DbCustomer DbCustomer { get; set; }
    }
}