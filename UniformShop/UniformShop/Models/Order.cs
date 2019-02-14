using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long orderId { get; set; }
        public long itemId { get; set; }
        [ForeignKey("custId")]
        public virtual Customer Customer { get; set; }
        public string date { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string modifiedBy { get; set; }
        public string modifiedDate { get; set; }
    }
}
