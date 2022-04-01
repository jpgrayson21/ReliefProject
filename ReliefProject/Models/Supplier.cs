using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Supplier : Organization
    {
        [Required]
        public string SupplierFirstName { get; set; }

        [Required]
        public string SupplierLastName { get; set; }

        [Required]
        public string SupplierEmail { get; set; }

        public string SupplierPhone { get; set; }
    }
}
