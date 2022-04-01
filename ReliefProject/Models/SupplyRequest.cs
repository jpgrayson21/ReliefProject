using System;
namespace ReliefProject.Models
{
    public class SupplyRequest
    {
        public int RequestID { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
        public string AidType { get; set; }
        public string Notes { get; set; }
        public Organization Supplier { get; set; }
        public Organization Org { get; set; }
    }
}
