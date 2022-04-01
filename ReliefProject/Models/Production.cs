using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Production
    {
        [Key]
        [Required]
        public int ProductionId { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public string Notes { get; set; }
    }
}
