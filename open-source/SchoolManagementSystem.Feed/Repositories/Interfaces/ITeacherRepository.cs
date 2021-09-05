using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface ITeacherRepository : IRepositoryBase<TeacherData>
    {
        bool IsTeacherExist(string PassportOrId);

        List<TeacherViewModel> GetAllTeachers();
        int TeacherCount();
    }

    public interface ITeacherAddressRepository : IRepositoryBase<TeacherAddressData>
    {
    }
}
