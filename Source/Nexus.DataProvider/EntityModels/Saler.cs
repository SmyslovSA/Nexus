using System.Collections.Generic;

namespace Nexus.DataProvider.EntityModels
{
    public class Saler
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string CompanyName { get; set; }

        public List<Product> Products { get; set; }

        public List<Gallery> Gallery { get; set; }

        public int DbUserId { get; set; }

        public virtual DbUser DbUser { get; set; }
    }
}