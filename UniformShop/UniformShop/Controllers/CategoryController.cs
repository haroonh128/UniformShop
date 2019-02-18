using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniformShop.Models;
using UniformShop.Repository;

namespace UniformShop.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository<Category> _context;
        public CategoryController(ICategoryRepository<Category> context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            IEnumerable<Category> categories = _context.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}",Name="Get")]
        public IActionResult Get(long Id) {
            Category category = _context.Get(Id);
            if (category == null)
            {
                return NotFound("The Category Could not be found");
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category category) {
            _context.Add(category);
            return CreatedAtRoute("Get",new { Id=category.categoryId},category);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id,[FromBody]Category category) {
            Category cat = _context.Get(id);
            if (category==null) {
                return NotFound("The Category not found");
            }
            _context.Update(cat,category);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Category category = _context.Get(id);
            if (category==null) {
                return NotFound("");
            }
            _context.Delete(category);
            return NoContent();
        }
    }
}