using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductFinder.Business.Abstract;
using ProductFinder.Business.Concrete;
using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAllProducts();
        }
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _productService.CreateProduct(product);
        }
        [HttpPut]
        public Product Put([FromBody] Product product)
        {
            return _productService.UpdateProduct(product);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
