using System;
using System.Linq;

namespace ReliefProject.Models
{
    public interface IReliefRepository
    {
        IQueryable<SupplyRequest> Requests { get; }
        IQueryable<Organization> Organizations { get; }

        public void AddRequest(SupplyRequest sr);
        public void EditRequest(SupplyRequest sr);
        public void DeleteRequest(SupplyRequest sr);
    }
}
