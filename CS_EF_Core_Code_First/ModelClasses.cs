using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EF_Core_Code_First
{
    public class Category
    {
        [Key] // Primary Identity Key
        public int CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; } // ONe-to-Many
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int CategoryId { get; set; } // FOreign Key
        public Category Category { get; set; } // The Reference One-to-One
    }
}
