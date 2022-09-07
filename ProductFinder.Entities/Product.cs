using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductFinder.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public string State { get; set; }
        public int IsDeleted { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
