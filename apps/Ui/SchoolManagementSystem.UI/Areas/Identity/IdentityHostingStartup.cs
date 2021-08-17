using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagementSystem.UI.Data;

[assembly: HostingStartup(typeof(SchoolManagementSystem.UI.Areas.Identity.IdentityHostingStartup))]
namespace SchoolManagementSystem.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SchoolManagementSystemUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SchoolManagementSystemUIContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SchoolManagementSystemUIContext>();
            });
        }
    }
}