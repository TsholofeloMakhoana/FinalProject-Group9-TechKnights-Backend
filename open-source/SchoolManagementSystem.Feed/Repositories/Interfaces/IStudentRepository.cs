using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IStudentRepository : IRepositoryBase<StudentData>
    {
        bool IsStudentExist(string studentPassportOrId);
        StudentViewModel GetStudent(int id);
        List<StudentViewModel> GetAllStudents();
        int StudentCount();
    }

    public interface IStudentAddressRepository : IRepositoryBase<StudentAddressData>
    {

    }
}
