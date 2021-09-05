using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IStudentService
    {
        string CreateStudent(StudentViewModel model);

        List<StudentViewModel> GetAllStudents();

        int StudentCount();
    }   
}
