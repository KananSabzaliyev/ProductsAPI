using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductFinder.Business.Abstract;
using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {

        private IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        [HttpGet]
        public List<ProductCategory> Get()
        {
            return _productCategoryService.GetAllProductCategory();
        }
        [HttpGet("{id}")]
        public ProductCategory Get(int id)
        {
            return _productCategoryService.GetProductCategoryById(id);
        }
        [HttpPost]
        public ProductCategory Post([FromBody] ProductCategory product)
        {
            return _productCategoryService.CreateProductCategory(product);
        }
        [HttpPut]
        public ProductCategory Put([FromBody] ProductCategory product)
        {
            return _productCategoryService.UpdateProductCategory(product);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productCategoryService.DeleteProductCategory(id);
        }
    }
}
