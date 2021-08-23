
using SchoolManagementSystem.Domain.Data;

namespace SchoolManagementSystem.Domain.Services
{
    public interface  ITeacherService
    {
        string CreateTeacher(TeacherViewModel model);
    } 
}
