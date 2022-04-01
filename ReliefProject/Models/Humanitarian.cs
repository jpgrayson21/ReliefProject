using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Humanitarian : Organization
    {
        [Required]
        public string RequesterFirstName { get; set; }

        [Required]
        public string RequesterLastName { get; set; }

        [Required]
        public string RequesterEmail { get; set; }

        public string RequesterPhone { get; set; }
    }
}
