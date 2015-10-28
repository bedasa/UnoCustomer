using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Data.Entities;

namespace Uno.Data
{
    public class UnoDbContext : DbContext
    {
        public UnoDbContext() : this("DevUnoConnection")
        {
        }

        public UnoDbContext(string connectionStringName) : base(connectionStringName)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
