using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public Product()
        {
            Purchases = new List<Purchase>();
        }

    }
}
