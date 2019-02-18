using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniformShop.Models;
using UniformShop.Repository;

namespace UniformShop.DataManager
{
    public class CategoryManager:ICategoryRepository<Category>
    {
        private UniformShopContext _context;
        public CategoryManager(UniformShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll() {
            return _context.Categories.ToList();
        }

        public Category Get(long Id) {
            return _context.Categories.FirstOrDefault(x=>x.categoryId==Id);
        }

        public void Add(Category cat) {
            _context.Add(cat);
            _context.SaveChanges();
        }

        public void Update(Category cat,Category ca) {
            cat.categoryName = ca.categoryName;
            _context.SaveChanges();
        }

        public void Delete(Category cat) {
            _context.Remove(cat);
            _context.SaveChanges();
        }
    }
}
