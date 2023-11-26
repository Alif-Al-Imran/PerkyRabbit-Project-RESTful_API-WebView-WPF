using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer, int, bool>
    {
        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }
        public bool Create(Customer Cus)
        {
            db.Customers.Add(Cus);
            return db.SaveChanges() > 0;
        }
        public bool Update(Customer Cus)
        {
            var ex = db.Customers.Find(Cus.Id);
            db.Entry(ex).CurrentValues.SetValues(Cus);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = db.Customers.Find(id);
            db.Customers.Remove(ex);
            return db.SaveChanges() > 0;
        }

    }
}
