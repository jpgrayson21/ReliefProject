using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReliefProject.Areas.Identity.Data;
using ReliefProject.Data;

[assembly: HostingStartup(typeof(ReliefProject.Areas.Identity.IdentityHostingStartup))]
namespace ReliefProject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ReliefDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ReliefDbContextConnection")));

                services.AddDefaultIdentity<ReliefProjectUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ReliefDbContext>();
            });
        }
    }
}