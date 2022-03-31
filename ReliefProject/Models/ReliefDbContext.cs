using System;
using Microsoft.EntityFrameworkCore;

namespace ReliefProject.Models
{
    public class ReliefDbContext : DbContext
    {
        public ReliefDbContext(DbContextOptions<ReliefDbContext> options) : base(options)
        {

        }

        public DbSet<SupplyRequest> Requests { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}
