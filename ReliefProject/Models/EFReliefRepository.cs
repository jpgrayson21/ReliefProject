using System;
using System.Linq;

namespace ReliefProject.Models
{
    public class EFReliefRepository : IReliefRepository
    {
        private ReliefDbContext _context { get; set; }

        public EFReliefRepository(ReliefDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<SupplyRequest> Requests => _context.Requests;
        public IQueryable<Organization> Organizations => _context.Organizations;

        public void AddRequest(SupplyRequest sr)
        {
            _context.Add(sr);
            _context.SaveChanges();
        }

        public void EditRequest(SupplyRequest sr)
        {
            _context.Update(sr);
            _context.SaveChanges();
        }

        public void DeleteRequest(SupplyRequest sr)
        {
            _context.Remove(sr);
            _context.SaveChanges();
        }
    }
}
