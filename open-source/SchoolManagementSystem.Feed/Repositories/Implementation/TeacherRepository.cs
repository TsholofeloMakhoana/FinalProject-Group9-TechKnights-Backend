using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Feed
{
    public class TeacherRepository : RepositoryBase<TeacherData>, ITeacherRepository
    {
        public TeacherRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }


    public class TeacherAddressRepository : RepositoryBase<TeacherAddressData>, ITeacherAddressRepository
    {
        public TeacherAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }
}
