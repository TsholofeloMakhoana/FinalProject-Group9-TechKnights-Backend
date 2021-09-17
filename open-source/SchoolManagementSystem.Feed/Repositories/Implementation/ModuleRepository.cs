using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.Feed
{
    public class ModuleRepository : RepositoryBase<ModuleData>, IModuleRepository
    {

        #region ctr
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public ModuleRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }
        #endregion

        public List<ModuleViewModel> GetAllModule()
        {
            return (from m in _schoolManagementDbConnector.ModuleData
                    join g in _schoolManagementDbConnector.GradeData on m.GradeId equals g.GradeId
                    join d in _schoolManagementDbConnector.TeacherData on m.TeacherId equals d.TeacherId
                    select new ModuleViewModel
                    {
                        ModuleId = m.ModuleId,
                        Fullnames = d.Firstname + " " + d.Surname,
                        GradeId = m.GradeId,
                        Grade = g.Grade,
                        Module = m.Module,
                        PassPoint = m.PassPoint,
                        Description = m.Description,
                        DateCreated = m.DateCreated,
                        CreatedBy = m.CreatedBy,
                        DateModified = m.DateCreated,
                        ModifiedBy = m.ModifiedBy
                    }).ToList();
        }
    }
}
