using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.Entities
{
    public class ProductCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
