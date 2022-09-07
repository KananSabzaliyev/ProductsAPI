using ProductFinder.Business.Abstract;
using ProductFinder.DataAccess.Abstract;
using ProductFinder.DataAccess.Concrete;
using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}
