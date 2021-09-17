using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IStudentService
    {
        string CreateStudent(StudentViewModel model);
        List<StudentViewModel> GetAllStudents();
        StudentViewModel GetStudentById(int id);
        string UpdateUserId(int id, string userId);
        string IsStudentExist(string studentPassportOrId);
        string UpdateStudentDetails(StudentViewModel model);
        string DeleteStudent(int id);
        StudentViewModel GetStudentByEmailAddress(string emailAddress);
        string IsEmailExist(string emailAddress);
        int StudentCount();
    }   
}
