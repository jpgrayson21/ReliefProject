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

        // Read in IQueryables
        public IQueryable<Category> Categories => _context.Categories;
        public IQueryable<Donation> Donations => _context.Donations;
        public IQueryable<Humanitarian> Humanitarians => _context.Humanitarians;
        public IQueryable<Product> Products => _context.Products;
        public IQueryable<Production> Productions => _context.Productions;
        public IQueryable<Request> Requests => _context.Requests;
        public IQueryable<Supplier> Suppliers => _context.Suppliers;

        // Allow for Interface methods
        public void AddRequest(Request request)
        {
            _context.Requests.Add(request);
            _context.SaveChanges();
        }

        public void EditRequest(Request request)
        {
            _context.Update(request);
            _context.SaveChanges();
        }

        public void DeleteRequest(Request request)
        {
            _context.Remove(request);
            _context.SaveChanges();
        }

        public void AddDonation(Donation donation)
        {
            _context.Add(donation);
            _context.SaveChanges();
        }

        public void EditDonation(Donation donation)
        {
            _context.Update(donation);
            _context.SaveChanges();
        }

        public void DeleteDonation(Donation donation)
        {
            _context.Remove(donation);
            _context.SaveChanges();
        }
    }
}
