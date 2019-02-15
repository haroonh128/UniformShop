using Microsoft.EntityFrameworkCore;

namespace UniformShop.Models
{
    public class UniformShopContext:DbContext
    {
        public UniformShopContext(DbContextOptions options)
        :base(options){
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<size> Sizes { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<variation> Variations { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}
    }
}
