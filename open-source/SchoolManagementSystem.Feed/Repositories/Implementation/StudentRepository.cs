using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public class StudentRepository : RepositoryBase<StudentData>, IStudentRepository
    {    
        public StudentRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {     
        }

        public List<StudentData> GetStudents()
        {
            throw new System.NotImplementedException();
        }
    }


    public class StudentAddressRepository : RepositoryBase<StudentAddressData>, IStudentAddressRepository
    {
        public StudentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
        }
    }
}
