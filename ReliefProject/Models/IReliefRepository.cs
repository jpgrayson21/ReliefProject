using System;
using System.Linq;

namespace ReliefProject.Models
{
    public interface IReliefRepository
    {
        // Set Table IQueriables
        IQueryable<Category> Categories { get; }
        IQueryable<Donation> Donations { get; }
        IQueryable<Humanitarian> Humanitarians { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Production> Productions { get; }
        IQueryable<Request> Requests { get; }
        IQueryable<Supplier> Suppliers { get; }

        // Allow for Request CRUD
        public void AddRequest(Request request);
        public void EditRequest(Request request);
        public void DeleteRequest(Request request);

        // Allow for Donation CRUD
        public void AddDonation(Donation donation);
        public void EditDonation(Donation donation);
        public void DeleteDonation(Donation donation);
    }
}
