

using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IGradeService
    {
         string CreateGrade(GradeViewModel model);

        List<GradeViewModel> ListAllGrades();
    }
}
