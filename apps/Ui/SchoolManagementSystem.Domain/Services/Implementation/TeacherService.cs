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
    public class TeacherService : ITeacherService
    {

        #region ctr
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public TeacherService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateTeacher(TeacherViewModel model)
        {
            try
            {
                var vModel = JsonConvert.DeserializeObject<TeacherData>(JsonConvert.SerializeObject(model));
                var createTeacher = _connectionWrapper.TeacherData.Create(vModel);
                if (createTeacher != null)
                {
                    string fullname = model.Firstname + " " + model.Surname;
                    TeacherNotificationHelper.ParentNotification(model.PersonalEmailAddress, fullname);
                    return createTeacher.TeacherId.ToString();
                }
            }
            catch (Exception ex)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }
        public string IsTeacherExist(string studentPassportOrId)
        {
            if (_connectionWrapper.TeacherData.IsTeacherExist(studentPassportOrId))
                return "Teacher with the same ID/Passport already exist in the system.";
            return HttpStatusCode.OK.ToString();
        }
        public string IsEmailExist(string emailAddress)
        {
            if (_connectionWrapper.TeacherData.IsEmailExist(emailAddress))
                return "Teacher with the same email address already exist in the system.";
            return HttpStatusCode.OK.ToString();
        }

        public List<TeacherViewModel> GetTeachers()
        {
            return _connectionWrapper.TeacherData.GetAllTeachers();           
        }

        public TeacherViewModel GetTeachers(int id)
        {
            return _connectionWrapper.TeacherData.GetTeacher(id);
        }

        public string UpdateTeacherUserId(int id, string userId)
        {
            var get = _connectionWrapper.TeacherData.UpdateTeacherUserId(id, userId);
            if (get != null)
            {
                return HttpStatusCode.OK.ToString();
            }
            return get;
        }
        public int TeacherCount()
        {
            var teaCount = GetTeachers().Count();
            if (teaCount > 0)
                return teaCount;
            return 0;
        }


        public string DeleteTeacher(int id)
        {
            var update = _connectionWrapper.TeacherData.DeleteTeacher(id);
            if (update == HttpStatusCode.OK.ToString())
            {
                return update;
            }
            return update;
        }
        public string UpdateTeacherDetails(TeacherViewModel model)
        {
            var update = _connectionWrapper.TeacherData.UpdateTeacherDetails(model);
            if (update == HttpStatusCode.OK.ToString())
            {
                return update;
            }
            return update;
        }
    }
}
