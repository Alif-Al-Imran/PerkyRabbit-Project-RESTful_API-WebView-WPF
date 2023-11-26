using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PurProDTO : ProductDTO
    {
        public List<PurchaseDTO> Purchases { get; set; }
        public PurProDTO()
        {
            Purchases = new List<PurchaseDTO>();
        }
    }
}
