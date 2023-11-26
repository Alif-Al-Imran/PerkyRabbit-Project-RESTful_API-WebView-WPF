using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Model;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, int, bool> CustomerData()
        {
            return new CustomerRepo();
        }
        public static IRepo<Product, int, bool> ProductData()
        {
            return new ProductRepo();
        }
        public static IRepo<Purchase, int, bool> PurchaseData()
        {
            return new PurchaseRepo();
        }
        
    }
}
