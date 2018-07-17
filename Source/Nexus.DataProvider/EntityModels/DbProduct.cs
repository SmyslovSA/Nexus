﻿namespace Nexus.DataProvider.EntityModels
{
    public class DbProduct
    {
        public int Id { get; set; }

        public int PartNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Maker { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public int DbOrderId { get; set; }

        public virtual DbOrder DbOrder { get; set; }

        public int DbSalerId { get; set; }

        public virtual DbSaler DbSaler { get; set; }
    }
}