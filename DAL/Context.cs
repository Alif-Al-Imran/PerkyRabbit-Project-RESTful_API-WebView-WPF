using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Model;

namespace DAL
{
    internal class Context: DbContext
    {
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> purchases { get; set; }

    }
}
