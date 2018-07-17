using System;
using System.Collections.Generic;

namespace Nexus.DataProvider.EntityModels
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Count { get; set; }

        public int OrderNumber { get; set; }

        public List<Product> Products { get; set; }

        public int DbCustomerId { get; set; }

        public virtual Customer DbCustomer { get; set; }
    }
}