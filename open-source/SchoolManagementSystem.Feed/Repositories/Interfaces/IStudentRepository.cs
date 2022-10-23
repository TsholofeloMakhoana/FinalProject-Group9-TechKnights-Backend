using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IStudentRepository : IRepositoryBase<StudentData>
    {        
        bool IsStudentExist(string studentPassportOrId);
        bool IsEmailExist(string emailAddress);
        StudentViewModel GetStudent(int id);
        StudentViewModel GetStudentByEmailAddress(string emailAddress);
        List<StudentViewModel> GetAllStudents();
        string UpdateUserId(int id, string userId);
        string UpdateStudentDetails(StudentViewModel model);
        string DeleteStudent(int id);
    }

    public interface IStudentAddressRepository : IRepositoryBase<StudentAddressData>
    {

    }
}
