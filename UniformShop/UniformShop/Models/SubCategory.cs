using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class SubCategory
    {
        [Key]
        public int subCategoryId { get; set; }
        public string subCategoryName { get; set; }
        [ForeignKey("categoryId")]
        public virtual Category Category { get; set; }
    }
}
