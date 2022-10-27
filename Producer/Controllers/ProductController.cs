using Microsoft.AspNetCore.Mvc;
using Producer.Models;
using Producer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        ProductService productService= new ProductService();
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.getAllProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(string id)
        {
            return productService.getProductById(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public Product Post([FromBody] string productName, [FromBody] int qty)
        {
            return productService.saveProduct(productName, qty);
        }

    }
}
