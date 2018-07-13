using System.Collections.Generic;

namespace testdb.consoleModels
{
    public class DbSaler
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string CompanyName { get; set; }

        public List<DbProduct> Products { get; set; }

        public List<DbGallery> Gallery { get; set; }

        public int DbUserId { get; set; }

        public virtual DbUser DbUser { get; set; }
    }
}