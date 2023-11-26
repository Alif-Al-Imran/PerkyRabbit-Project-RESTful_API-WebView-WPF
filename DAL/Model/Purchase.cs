using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class Purchase
    {
        [Key]
        public int id { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int Cid { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int Pid { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public DateTime Date { get; set; }
       
        
    }
}
