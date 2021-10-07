using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Notification;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class ParentService : IParentService
    {

        #region ctor
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public ParentService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateParent(ParentViewModel model)
        {
            try
            {
                var vModel = JsonConvert.DeserializeObject<ParentData>(JsonConvert.SerializeObject(model));
                var createParent = _connectionWrapper.ParentData.Create(vModel);
                if (createParent != null)
                {
                    string fullname = model.Firstname + " " + model.Surname;
                    ParentNotificationHelper.ParentNotification(model.PersonalEmailAddress, fullname);
                    return createParent.ParentId.ToString();
                }
            }
            catch
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }


        public string IsParentExist(string studentPassportOrId)
        {
            if (_connectionWrapper.ParentData.IsParentExist(studentPassportOrId))
                return "Parent with the same ID/Passport already exist in the system";
            return HttpStatusCode.OK.ToString();
        }
        public string IsEmailExist(string emailAddress)
        {
            if (_connectionWrapper.ParentData.IsEmailExist(emailAddress))
                return "Parent with the same email address already exist in the system.";
            return HttpStatusCode.OK.ToString();
        }
        public ParentViewModel GetParent(int id)
        {
            return _connectionWrapper.ParentData.GetParent(id);
        }

        public List<ParentViewModel> GetAllParents()
        {
            return _connectionWrapper.ParentData.GetAllParents();
        }

        public int ParentCount()
        {
            var stuCount = GetAllParents().Count();
            if (stuCount > 0)
                return stuCount;
            return 0;
        }
        public string UpdateParentUserId(int id, string userId)
        {
            var get = _connectionWrapper.ParentData.UpdateParentUserId(id, userId);
            if (get != null)
            {
                return HttpStatusCode.OK.ToString();
            }
            return get;
        }

        public string DeleteParent(int id)
        {
            var update = _connectionWrapper.ParentData.DeleteParent(id);
            if (update == HttpStatusCode.OK.ToString())
            {
                return update;
            }
            return update;
        }
        public string UpdateParentDetails(ParentViewModel model)
        {
            var update = _connectionWrapper.ParentData.UpdateParentDetails(model);
            if (update == HttpStatusCode.OK.ToString())
            {
                return update;
            }
            return update;
        }
    }

}
