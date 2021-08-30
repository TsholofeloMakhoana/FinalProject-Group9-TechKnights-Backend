
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;



namespace SchoolManagementSystem.Data
{
    public class SchoolManagementDbConnector : DbContext
    {
        public SchoolManagementDbConnector(DbContextOptions option) : base(option)
        {

        }


        #region Teachers Student Parent Data

        public DbSet<StudentData> StudentData { get; set; }
        public DbSet<StudentAddressData> StudentAddressData { get; set; }
        public DbSet<ParentData> ParentData { get; set; }
        public DbSet<ParentAddressData> ParentAddressData { get; set; }
        public DbSet<TeacherData> TeacherData { get; set; }
        public DbSet<TeacherAddressData> TeacherAddressData { get; set; }
        public DbSet<AddressData> AddressData { get; set; }

        #endregion





        public DbSet<GradeData> GradeData { get; set; }
        public DbSet<ModuleData> ModuleData { get; set; }

    }
}
