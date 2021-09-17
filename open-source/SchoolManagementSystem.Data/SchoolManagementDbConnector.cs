
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;



namespace SchoolManagementSystem.Data
{

    public class SchoolManagementDbConnector : IdentityDbContext<IdentityUser>
    {
        public SchoolManagementDbConnector(DbContextOptions<SchoolManagementDbConnector> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        #region Teachers Student Parent Data

        public DbSet<StudentData> StudentData { get; set; }
        public DbSet<StudentAddressData> StudentAddressData { get; set; }
        public DbSet<ParentData> ParentData { get; set; }    
        public DbSet<TeacherData> TeacherData { get; set; }
        public DbSet<AddressData> AddressData { get; set; }

        #endregion

        public DbSet<InvoiceData> InvoiceData { get; set; }

        public DbSet<GradeData> GradeData { get; set; }
        public DbSet<ModuleData> ModuleData { get; set; }


        public DbSet<EmailAuditData> EmailAuditData { get; set; }
    }
}
