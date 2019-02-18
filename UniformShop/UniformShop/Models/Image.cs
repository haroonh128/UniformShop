using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class Image
    {
        [Key]
        public long imgId { get; set; }
        public string imgName { get; set; }
        public string imgUrl { get; set; }

    }
}
