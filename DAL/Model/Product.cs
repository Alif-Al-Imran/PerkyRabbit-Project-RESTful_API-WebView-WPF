using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public Product()
        {
            Purchases = new List<Purchase>();
        }

    }
}
