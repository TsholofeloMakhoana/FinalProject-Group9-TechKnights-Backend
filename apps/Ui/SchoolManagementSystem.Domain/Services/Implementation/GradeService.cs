using Newtonsoft.Json;
using SchoolManagementSystem.Shared;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class GradeService : IGradeService
    {

        #region ctr
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public GradeService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateGrade(GradeViewModel model)
        {
            try
            {
                model.CreatedBy = "SystemAdmin";
                var vModel = JsonConvert.DeserializeObject<GradeData>(JsonConvert.SerializeObject(model));             
                if(_connectionWrapper.GradeData.Create(vModel) != null)
                {
                    return HttpStatusCode.OK.ToString();
                }
            }
            catch(Exception ex)
            {
                return DatabaseErrors.ErrorOccured +"--"+ ex.Message;
            }
            return null;
        }
        public List<GradeViewModel> ListAllGrades()
        {
            return _connectionWrapper.GradeData.GetAllGrades();
        }
    }
}
