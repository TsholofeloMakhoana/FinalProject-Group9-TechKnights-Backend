using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.Feed
{
    public class TeacherRepository : RepositoryBase<TeacherData>, ITeacherRepository
    {
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public TeacherRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }


        public bool IsTeacherExist(string PassportOrId)
        {
            var sCheck = from m in _schoolManagementDbConnector.TeacherData
                         where m.IdOrPassport == PassportOrId
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }


        public List<TeacherViewModel> GetAllTeachers()
        {
            return null;
        }

        public int TeacherCount()
        {
            return GetAllTeachers().Count();
        }
    }


    public class TeacherAddressRepository : RepositoryBase<TeacherAddressData>, ITeacherAddressRepository
    {
        public TeacherAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }
}
