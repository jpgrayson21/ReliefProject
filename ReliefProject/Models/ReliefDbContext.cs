using System;
using Microsoft.EntityFrameworkCore;

namespace ReliefProject.Models
{
    public class ReliefDbContext : DbContext
    {
        public ReliefDbContext(DbContextOptions<ReliefDbContext> options) : base(options)
        {

        }

        // Connect to tables in database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Humanitarian> Humanitarians { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        // Only needed for seeding dummy data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Seed Categories Table
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Clothing"},
                new Category { CategoryId = 2, CategoryName = "Toiletries" },
                new Category { CategoryId = 3, CategoryName = "Food" },
                new Category { CategoryId = 4, CategoryName = "Furniture" },
                new Category { CategoryId = 5, CategoryName = "Toys" }
            );

            // Seed Donations Table
            mb.Entity<Donation>().HasData(
                new Donation { DonationId = 1, Discount = "Free", Quantity = 500, ProductionId = 1, Notes = "", TimeStamp = DateTime.Now },
                new Donation { DonationId = 2, Discount = "Free", Quantity = 1000, ProductionId = 2, Notes = "", TimeStamp = DateTime.Now },
                new Donation { DonationId = 3, Discount = "50% Off", Quantity = 4500, ProductionId = 3, Notes = "", TimeStamp = DateTime.Now },
                new Donation { DonationId = 4, Discount = "Free", Quantity = 500, ProductionId = 3, Notes = "Manufacturing Issues", TimeStamp = DateTime.Now },
                new Donation { DonationId = 5, Discount = "Free", Quantity = 1200, ProductionId = 4, Notes = "", TimeStamp = DateTime.Now, }
            );

            // Seed Humanitarians Table
            mb.Entity<Humanitarian>().HasData(
                new Humanitarian { OrgId = 1, OrgName = "AmeriCares", OrgAddress = "88 Hamilton Ave", OrgCity = "Stamford", OrgState = "CT", OrgZip = "06902", OrgCountry = "United States of America", OrgPhone = "203-658-9500", RequesterEmail = "requester@americares.org", RequesterFirstName = "John", RequesterLastName = "Adams", RequesterPhone = "555-765-4321" },
                new Humanitarian { OrgId = 2, OrgName = "Red Cross", OrgAddress = "430 17th Street NW", OrgCity = "Washington DC", OrgState = "DC", OrgZip = "20006", OrgCountry = "United States of America", OrgPhone = "202-303-4498", RequesterEmail = "requester@redcross.org", RequesterFirstName = "George", RequesterLastName = "Washington", RequesterPhone = "555-123-4567" },
                new Humanitarian { OrgId = 3, OrgName = "Doctors Without Borders", OrgAddress = "78 rue de Lausanne Case Postale 116", OrgCity = "Geneva", OrgState = "CH", OrgZip = "1211", OrgCountry = "Switzerland", OrgPhone = "212-763-5779", RequesterEmail = "requester@doctors.org", RequesterFirstName = "James", RequesterLastName = "Madison", RequesterPhone = "555-666-7777" }
            );

            // Seed Products Table
            mb.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Water Bottle", Size = "1L", Notes = "", CategoryId = 3 },
                new Product { ProductId = 2, ProductName = "T-Shirt", Size = "M", Notes = "", CategoryId = 1 },
                new Product { ProductId = 3, ProductName = "Basketball", Size = "29 in", Notes = "Women's Size", CategoryId = 5 },
                new Product { ProductId = 4, ProductName = "Paper Towel", Size = "11 in", Notes = "", CategoryId = 2 },
                new Product { ProductId = 5, ProductName = "Mattress", Size = "60X80 in", Notes = "Queen Size", CategoryId = 4 }
            );

            // Seed Productions Table
            mb.Entity<Production>().HasData(
                new Production { ProductionId = 1, SupplierId = 4, ProductId = 1, Notes = "40 Count"},
                new Production { ProductionId = 2,  SupplierId = 4, ProductId = 2, Notes = "" },
                new Production { ProductionId = 3,  SupplierId = 4, ProductId = 4, Notes = "12 Count" },

                new Production { ProductionId = 4,  SupplierId = 5, ProductId = 4, Notes = "24 Count" },

                new Production { ProductionId = 5,  SupplierId = 6, ProductId = 1, Notes = "40 Count" },
                new Production { ProductionId = 6,  SupplierId = 6, ProductId = 3, Notes = "" },
                new Production { ProductionId = 7,  SupplierId = 6, ProductId = 4, Notes = "12 Count" }
            );

            // Seed Requests Table
            mb.Entity<Request>().HasData(
                new Request { RequestId = 1, ProductId = 1, HumanitarianId = 1, AidType = "Natural Disaster Recovery", Amount = 1500, Notes = "", TimeStamp = DateTime.Now },
                new Request { RequestId = 2, ProductId = 4, HumanitarianId = 3, AidType = "Third World Production", Amount = 6000, Notes = "", TimeStamp = DateTime.Now },
                new Request { RequestId = 3, ProductId = 5, HumanitarianId = 2, AidType = "Refugee Assistance", Amount = 200, Notes = "", TimeStamp = DateTime.Now },
                new Request { RequestId = 4, ProductId = 1, HumanitarianId = 2, AidType = "Refugee Assistance", Amount = 2000, Notes = "", TimeStamp = DateTime.Now }
            );

            // Seed Suppliers Table
            mb.Entity<Supplier>().HasData(
                new Supplier { OrgId = 4, OrgName = "Kirkland", OrgAddress = "999 Lake Drive", OrgCity = "Issaquah", OrgState = "WA", OrgZip = "98027", OrgCountry = "United States of America", OrgPhone = "425-313-8100", SupplierEmail = "supplier@kirkland.org", SupplierFirstName = "James", SupplierLastName = "Monroe", SupplierPhone = "555-111-2222"},
                new Supplier { OrgId = 5, OrgName = "Bounty", OrgAddress = "1634 Beach Ave", OrgCity = "Mehoopany", OrgState = "PA", OrgZip = "18629", OrgCountry = "United States of America", OrgPhone = "570-833-5141", SupplierEmail = "supplier@bounty.org", SupplierFirstName = "Alexander", SupplierLastName = "Hamilton", SupplierPhone = "555-333-4444" },
                new Supplier { OrgId = 6, OrgName = "Great Value", OrgAddress = "702 SW 8th St", OrgCity = "St Bentonville", OrgState = "AK", OrgZip = "72716", OrgCountry = "United States of America", OrgPhone = "801-221-0600", SupplierEmail = "supplier@walmart.org", SupplierFirstName = "Benjamin", SupplierLastName = "Franklin", SupplierPhone = "555-888-9999" }
            );
        }
    }
}
