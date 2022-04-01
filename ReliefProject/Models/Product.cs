using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }
        
        public string Size { get; set; }

        public string Notes { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
