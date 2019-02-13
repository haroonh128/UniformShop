using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniformShop.Models
{
    public class UniformShopContext:DbContext
    {
        public UniformShopContext(DbContextOptions options)
        :base(options){
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
