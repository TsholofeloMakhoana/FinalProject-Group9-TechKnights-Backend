using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.Feed
{
    public class GradeRepository : RepositoryBase<GradeData>, IGradeRepository
    {
        #region ctor
        private readonly SchoolManagementDbConnector schoolManagementDbConnector;
        public GradeRepository(SchoolManagementDbConnector _schoolManagementDbConnector)
            : base(_schoolManagementDbConnector)
        {
            schoolManagementDbConnector = _schoolManagementDbConnector;
        }
        #endregion

        public List<GradeViewModel> GetAllGrades()
        {
            List<GradeViewModel> sqlGet = new List<GradeViewModel>();

            sqlGet = (from m in schoolManagementDbConnector.GradeData
                      select new GradeViewModel
                      {
                          GradeId = m.GradeId,
                          Grade = m.Grade,
                          GradePoint = m.GradePoint,
                          TotalFees =m.TotalFees,
                          GradeDescrption = m.GradeDescrption,
                          DateCreated = m.DateCreated,
                          DateModified =m.DateModified,
                          CreatedBy =m.CreatedBy,
                          ModifiedBy = m.ModifiedBy
                      }).ToList();

            return sqlGet;
        }
    }
}
