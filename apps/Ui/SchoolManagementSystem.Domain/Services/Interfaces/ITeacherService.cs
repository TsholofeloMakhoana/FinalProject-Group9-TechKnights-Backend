
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface  ITeacherService
    {
        string IsTeacherExist(string PassportOrId);
        string IsEmailExist(string emailAddress);
        string CreateTeacher(TeacherViewModel model);
        List<TeacherViewModel> GetTeachers();
        TeacherViewModel GetTeachers(int id);
        int TeacherCount();
        string UpdateTeacherUserId(int id, string userId);


        string DeleteTeacher(int id);
        string UpdateTeacherDetails(TeacherViewModel model);
    } 
}
