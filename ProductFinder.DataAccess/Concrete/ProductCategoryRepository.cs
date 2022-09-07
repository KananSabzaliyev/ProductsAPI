using ProductFinder.DataAccess.Abstract;
using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.DataAccess.Concrete
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        public ProductCategory CreateProductCategory(ProductCategory product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.ProductCategories.Add(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProductCategory(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                var deletedProduct = GetProductCategoryById(id);
                productDbContext.ProductCategories.Remove(deletedProduct);
                productDbContext.SaveChanges();
            }
        }

        public List<ProductCategory> GetAllProductCategory()
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.ProductCategories.ToList();
            }
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.ProductCategories.Find(id);
            }
        }

        public ProductCategory UpdateProductCategory(ProductCategory product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.ProductCategories.Update(product);
                return product;
            }
        }
    }
}
