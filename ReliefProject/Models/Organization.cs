using System;
using System.ComponentModel.DataAnnotations;

namespace ReliefProject.Models
{
    public class Organization
    {
        [Key]
        [Required]
        public int OrgId { get; set; }

        [Required]
        public string OrgName { get; set; }

        [Required]
        public string OrgPhone { get; set; }

        [Required]
        public string OrgAddress { get; set; }

        [Required]
        public string OrgCity { get; set; }

        public string OrgState { get; set; }

        public string OrgZip { get; set; }

        [Required]
        public string OrgCountry { get; set; }
    }
}
