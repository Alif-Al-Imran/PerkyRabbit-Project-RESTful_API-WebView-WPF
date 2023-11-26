using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Purchase
    {
        public int id { get; set; }
        public int Cid { get; set; }
        public virtual Customer Customer { get; set; }
        public int Pid { get; set; }
        public virtual Product Product { get; set; }
        public DateTime Date { get; set; }
       
        
    }
}
