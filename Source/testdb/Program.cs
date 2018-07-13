using testdb.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testdb.consoleModels;

namespace testdb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NexusContext db = new NexusContext())
            {
                db.Database.Delete();
                DbUser user = new DbUser { FirstName = "John", LastName = "Doe" };
                db.DbUser.Add(user);
                db.SaveChanges();
            }
        }
    }
}
