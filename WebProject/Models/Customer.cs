using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public Customer()
        {
            Purchases = new List<Purchase>();
        }

    }
}
