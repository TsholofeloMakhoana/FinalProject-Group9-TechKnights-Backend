using SchoolManagementSystem.Shared;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IStudentService
    {
        string CreateStudent(StudentViewModel model);
    }   
}
