using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Model;

namespace DAL.Repos
{
    internal class PurchaseRepo : Repo, IRepo<Purchase, int, bool>
    {
        public List<Purchase> Get()
        {
            return db.purchases.ToList();
        }

        public Purchase Get(int id)
        {
            return db.purchases.Find(id);
        }
        public bool Create(Purchase Pur)
        {
            db.purchases.Add(Pur);
            return db.SaveChanges() > 0;
        }
        public bool Update(Purchase Pur)
        {
            var ex = db.purchases.Find(Pur.id);
            db.Entry(ex).CurrentValues.SetValues(Pur);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = db.purchases.Find(id);
            db.purchases.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
