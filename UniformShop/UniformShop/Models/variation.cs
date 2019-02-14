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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long varId { get; set; }
        [ForeignKey("colorId")]
        public ICollection<color> Color { get; set; }
        [ForeignKey("imgId")]
        public ICollection<Image> Image { get; set; }
    }
}
