using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_WebSite_Clothes_Electronics_Jawlary_.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be between 2 and 20")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
