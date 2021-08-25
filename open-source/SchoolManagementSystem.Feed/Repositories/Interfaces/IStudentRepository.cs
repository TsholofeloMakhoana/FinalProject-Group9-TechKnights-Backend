using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IStudentRepository : IRepositoryBase<StudentData>
    {
        List<StudentData> GetStudents();
    }

    public interface IStudentAddressRepository : IRepositoryBase<StudentAddressData>
    {

    }
}
