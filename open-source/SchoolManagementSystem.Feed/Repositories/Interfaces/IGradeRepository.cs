using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IGradeRepository : IRepositoryBase<GradeData>
    {
        List<GradeViewModel> GetAllGrades();
    }
}
