using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long custId { get; set; }
        public string custName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public long? cardNumber { get; set; }
        public bool? notifications { get; set; }
        public string email { get; set; }
    }
}
