using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long itemId { get; set; }
        public string itemName { get; set; }
        [ForeignKey("imgId")]
        public ICollection<Image>Images { get; set; }
        public long categoryId { get; set; }
        [ForeignKey("sizeId")]
        public virtual size Size { get; set; }
        [ForeignKey("colorId")]
        public virtual color Color { get; set; }
        public string description { get; set; }
        [ForeignKey("varId")]
        public ICollection<variation>variations { get; set; }
    }
}
