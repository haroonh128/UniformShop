using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long tranId { get; set; }
        public string tranDate { get; set; }
        public int totalAmt { get; set; }
        public virtual Order Order { get; set; }
        public int profit { get; set; }
        public bool status { get; set; }
        public string paymentMethod { get; set; }
    }
}
