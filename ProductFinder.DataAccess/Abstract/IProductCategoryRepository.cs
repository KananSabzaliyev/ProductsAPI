using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.DataAccess.Abstract
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetAllProductCategory();
        ProductCategory GetProductCategoryById(int id);
        ProductCategory CreateProductCategory(ProductCategory product);
        ProductCategory UpdateProductCategory(ProductCategory product);
        void DeleteProductCategory(int id);
    }
}
