
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;



namespace SchoolManagementSystem.Data
{
    public class SchoolManagementDbConnector : DbContext
    {
        public SchoolManagementDbConnector(DbContextOptions option) : base(option)
        {

        }
        #region Database Models

        public DbSet<StudentData> StudentData { get; set; }
        public DbSet<StudentAddressData> StudentAddressData { get; set; }
        public DbSet<ParentData> ParentData { get; set; }
        public DbSet<ParentAddressData> ParentAddressData { get; set; }
        public DbSet<TeacherData> TeacherData { get; set; }
        public DbSet<TeacherAddressData> TeacherAddressData { get; set; }

        #endregion
    }
}
