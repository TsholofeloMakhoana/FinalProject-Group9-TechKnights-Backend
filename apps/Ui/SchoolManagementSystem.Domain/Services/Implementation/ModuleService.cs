using Newtonsoft.Json;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class ModuleService : IModuleService
    {

        #region ctr
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public ModuleService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateModule(ModuleViewModel model)
        {
            if (model != null)
            {
                try
                {
                    model.CreatedBy = "SystemAdmin";
                    var vModel = JsonConvert.DeserializeObject<ModuleData>(JsonConvert.SerializeObject(model));
                    if (_connectionWrapper.ModuleData.Create(vModel) != null)
                    {
                        return HttpStatusCode.OK.ToString();
                    }
                }
                catch (Exception ex)
                {
                    return DatabaseErrors.ErrorOccured + "--" + ex.Message;
                }
            }
            return null;
        }

        public List<ModuleViewModel> ListAllModule()
        {
            return _connectionWrapper.ModuleData.GetAllModule();
        }
    }
}
