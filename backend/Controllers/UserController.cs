using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.ProductMaster;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductProvider productProvider;
        private readonly IProductRepository productRepository;

        public ProductController(
            IProductProvider productProvider,
            IProductRepository productRepository
        )
        {
            this.productProvider = productProvider;
            this.productRepository = productRepository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await productProvider.Get();
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] Product product)
        {
            await productRepository.Create(product);
        }
    }
}
