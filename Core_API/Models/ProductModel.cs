using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_API.Models
{
    public class ProductInfo
    {
        [Key]
        public int ProductRowId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(150)]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(150)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public int BasePrice { get; set; }
    }


    
}
