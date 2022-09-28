using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTasks.Concrete;
using MyTasks.Models;

namespace MyTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContect _productContect;
        public ProductController(ProductContect productContect)
        {
            _productContect = productContect;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductMainCategory>>> GetAllProducts()
        {
            if(_productContect==null)
            {
                return NotFound();
            }
            return await  _productContect.ProductMainCategories.ToListAsync();
        }
    }
}
