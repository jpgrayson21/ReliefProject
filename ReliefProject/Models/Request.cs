using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Request
    {
        [Key]
        [Required]
        public int RequestId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public string AidType { get; set; }

        public string Notes { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [Required]
        public int HumanitarianId { get; set; }
    }
}
