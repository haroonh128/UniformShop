using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class variation
    {
        [Key]
        public long varId { get; set; }
        public string varDescription { get; set; }
        [ForeignKey("colorId")]
        public virtual ICollection<color> Color { get; set; }
        [ForeignKey("imgId")]
        public virtual ICollection<Image> Image { get; set; }
        public bool Deleted { get; set; }
        //[ForeignKey("itemId")]
        //public virtual Item Item { get; set; }
    }
}
