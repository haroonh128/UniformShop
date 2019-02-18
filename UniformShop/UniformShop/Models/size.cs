using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class size
    {
        [Key]
        public long sizeId { get; set; }
        public string sizeName { get; set; }
        public string sizeDescription { get; set; }
    }
}
