using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long colorId { get; set; }
        public string colorName { get; set; }
    }
}
