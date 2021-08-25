
using SchoolManagementSystem.Domain.Data;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface  ITeacherService
    {
        string CreateTeacher(TeacherViewModel model);

        List<TeacherViewModel> GetTeachers();
    } 
}
