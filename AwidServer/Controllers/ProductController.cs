using AwidServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AwidServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        Contexts.AwidContext _dbContext;
        public ProductController(Contexts.AwidContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // Get : api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (this._dbContext.products == null)
                return NotFound();
            return await this._dbContext.products.ToListAsync();
        }

        // Get : api/Product/4
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(string id)
        {
            if (this._dbContext.products == null)
                return NotFound();

            var product = await _dbContext.products.FindAsync(id);

            if (product == null)
                return NotFound();

            return product;
        }

        // Post : api/Product
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product newProduct)
        {
            _dbContext.products.Add(newProduct);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);
        }
    }
}
