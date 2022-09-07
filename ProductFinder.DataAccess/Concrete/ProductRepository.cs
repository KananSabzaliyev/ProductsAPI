using ProductFinder.DataAccess.Abstract;
using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.Products.Add(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                var deletedProduct = GetProductById(id);
                productDbContext.Products.Remove(deletedProduct);
                productDbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.ToList();
            }
        }

        public Product GetProductById(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.Find(id);
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.Products.Update(product);
                productDbContext.SaveChanges();
                return product;
            }
        }
    }
}
