using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public class TeacherRepository : RepositoryBase<TeacherData>, ITeacherRepository
    {
        public TeacherRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }

        public List<TeacherData> GetTeachers()
        {
            throw new System.NotImplementedException();
        }
    }


    public class TeacherAddressRepository : RepositoryBase<TeacherAddressData>, ITeacherAddressRepository
    {
        public TeacherAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }
}
