using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Name Must be between 2 and 40")]
        public string Name { get; set; }
        [Range(20, 100000)]
        [DataType("money")]
        public decimal Price { get; set; }
        [MaxLength(200)]
        [Display(Name = "Product Image")]
        public string ProductImage { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
       
    }
}
