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
        public long imgId { get; set; }
        public long categoryId { get; set; }
        public long sizeId { get; set; }
        public long colorId { get; set; }
        public string description { get; set; }
        public long variationId { get; set; }
        public long discountId { get; set; }
    }
}
