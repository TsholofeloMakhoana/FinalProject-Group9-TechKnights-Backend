using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Feed
{
    public class StudentRepository : RepositoryBase<StudentData>, IStudentRepository
    {    
        public StudentRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {     
        }
    }


    public class StudentAddressRepository : RepositoryBase<StudentAddressData>, IStudentAddressRepository
    {
        public StudentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
        }
    }
}
