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
    public class ProductCategoryManager : IProductCategoryService
    {
        private IProductCategoryRepository _productRepository;
        public ProductCategoryManager()
        {
            _productRepository = new ProductCategoryRepository();
        }
        public ProductCategory CreateProductCategory(ProductCategory product)
        {
            return _productRepository.CreateProductCategory(product);
        }

        public void DeleteProductCategory(int id)
        {
            _productRepository.DeleteProductCategory(id);
        }

        public List<ProductCategory> GetAllProductCategory()
        {
            return _productRepository.GetAllProductCategory();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            return _productRepository.GetProductCategoryById(id);
        }

        public ProductCategory UpdateProductCategory(ProductCategory product)
        {
            return _productRepository.UpdateProductCategory(product);
        }
    }
}
