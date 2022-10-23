using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.UI.Data;

[assembly: HostingStartup(typeof(SchoolManagementSystem.UI.Areas.Identity.IdentityHostingStartup))]
namespace SchoolManagementSystem.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<SchoolManagementDbConnector>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SchoolManagementSystemUIContextConnection")));
                services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                 .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<SchoolManagementDbConnector>();

                services.AddRazorPages();
            });
        }
    }
}