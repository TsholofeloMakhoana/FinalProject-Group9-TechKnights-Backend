using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface ITeacherRepository : IRepositoryBase<TeacherData>
    {
        bool IsTeacherExist(string PassportOrId);
        bool IsEmailExist(string emailAdd);
        List<TeacherViewModel> GetAllTeachers();
        TeacherViewModel GetTeacher(int id);

        string UpdateTeacherUserId(int id, string userId);
        string DeleteTeacher(int id);
        string UpdateTeacherDetails(TeacherViewModel model);
    }

}
