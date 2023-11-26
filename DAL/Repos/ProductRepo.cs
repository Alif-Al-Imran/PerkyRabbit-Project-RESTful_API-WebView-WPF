using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Model;

namespace DAL.Repos
{
    internal class ProductRepo : Repo, IRepo<Product, int, bool>
    {
        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }
        public bool Create(Product Pro)
        {
            db.Products.Add(Pro);
            return db.SaveChanges() > 0;
        }
        public bool Update(Product Pro)
        {
            var ex = db.Products.Find(Pro.Id);
            db.Entry(ex).CurrentValues.SetValues(Pro);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = db.Products.Find(id);
            db.Products.Remove(ex);
            return db.SaveChanges() > 0;
        }

    }
}
