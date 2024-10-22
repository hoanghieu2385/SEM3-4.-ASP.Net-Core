using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Iphone 13",
                Description = "Old Product"
            });
            products.Add(new Product()
            {   Id = 2,
                Name = "Iphone 16",
                Description = "New Product"
            });
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
