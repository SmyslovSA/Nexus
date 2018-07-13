﻿using System.Collections.Generic;

namespace Nexus.DataProvider.EntityModels
{
    public class DbUser
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public List<DbCustomer> Customer { get; set; }

        public List<DbSaler> Saler { get; set; }
    }
}
