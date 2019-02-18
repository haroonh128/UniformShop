using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class OrderDetail
    {
        [Key]
        public long ordDetailId { get; set; }
        public virtual Order Order { get; set; }
        public bool orderStatus { get; set; }
        public int quantity { get; set; }
    }
}
