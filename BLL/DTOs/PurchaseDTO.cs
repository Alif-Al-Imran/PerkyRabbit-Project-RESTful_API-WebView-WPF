using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PurchaseDTO
    {
        public int Id { get; set; }
        [Required]
        public int Cid { get; set; }
        [Required]
        public int Pid { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
