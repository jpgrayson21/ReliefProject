using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Donation
    {
        [Key]
        [Required]
        public int DonationId { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Discount { get; set; }

        public string Notes { get; set; }

        [Required]
        public int ProductionId { get; set; }
    }
}
