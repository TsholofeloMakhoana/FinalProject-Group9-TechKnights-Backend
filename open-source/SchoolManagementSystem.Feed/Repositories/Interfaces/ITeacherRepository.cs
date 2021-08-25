using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface ITeacherRepository : IRepositoryBase<TeacherData>
    {
        List<TeacherData> GetTeachers();
    }

    public interface ITeacherAddressRepository : IRepositoryBase<TeacherAddressData>
    {
    }
}
