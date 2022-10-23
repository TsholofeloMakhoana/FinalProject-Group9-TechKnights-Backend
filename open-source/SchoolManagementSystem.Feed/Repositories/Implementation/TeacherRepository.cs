using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SchoolManagementSystem.Feed
{
    public class TeacherRepository : RepositoryBase<TeacherData>, ITeacherRepository
    {

        #region ctr
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public TeacherRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }
        #endregion

        public bool IsTeacherExist(string PassportOrId)
        {
            var sCheck = from m in _schoolManagementDbConnector.TeacherData
                         where m.IdOrPassport == PassportOrId
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }
        public bool IsEmailExist(string emailAdd)
        {
            var sCheck = from m in _schoolManagementDbConnector.TeacherData
                         where m.PersonalEmailAddress == emailAdd
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }

        public List<TeacherViewModel> GetAllTeachers()
        {
            List<TeacherViewModel> sqlGet = new List<TeacherViewModel>();

            sqlGet = (from m in _schoolManagementDbConnector.TeacherData
                      where m.IsActive == true
                      select new TeacherViewModel
                      {
                          TeacherId = m.TeacherId,
                          Firstname = m.Firstname,
                          Fullnames = m.Firstname + " " + m.Surname,
                          Midname = m.Midname,
                          Surname = m.Surname,
                          Title = m.Title,
                          Gender = m.Gender,
                          MaritalStatus = m.MaritalStatus,
                          IsSouthAfrican = m.IsSouthAfrican,
                          DateOfBirth = m.DateOfBirth,
                          IsActive = m.IsActive,
                          IdOrPassport = m.IdOrPassport,
                          HomeLanguage = m.HomeLanguage,
                          CountryOfBirth = m.CountryOfBirth,
                          PersonalEmailAddress = m.PersonalEmailAddress,
                          WorkTelNumber = m.WorkTelNumber,
                          HomeTelNumber = m.HomeTelNumber,
                          FaxNumber = m.FaxNumber,
                          CelPhoneNumber = m.CelPhoneNumber,
                          DateCreated = m.DateCreated,
                          CreatedBy = m.CreatedBy,
                          DateModified = m.DateModified,
                          ModifiedBy = m.ModifiedBy,
                          PreferedLanguage = m.PreferedLanguage,
                          CommunicationMethod = m.CommunicationMethod,

                      }).ToList();
            return sqlGet;
        }

        public TeacherViewModel GetTeacher(int id)
        {
            var sqlGet = new TeacherViewModel();

            sqlGet = (from m in _schoolManagementDbConnector.TeacherData
                      where m.TeacherId == id
                      select new TeacherViewModel
                      {
                          TeacherId = m.TeacherId,
                          Firstname = m.Firstname,
                          Midname = m.Midname,
                          Surname = m.Surname,
                          Fullnames = m.Firstname + " " + m.Surname,
                          Title = m.Title,
                          Gender = m.Gender,
                          MaritalStatus = m.MaritalStatus,
                          IsSouthAfrican = m.IsSouthAfrican,
                          DateOfBirth = m.DateOfBirth,
                          IsActive = m.IsActive,
                          IdOrPassport = m.IdOrPassport,
                          HomeLanguage = m.HomeLanguage,
                          CountryOfBirth = m.CountryOfBirth,
                          PersonalEmailAddress = m.PersonalEmailAddress,
                          WorkTelNumber = m.WorkTelNumber,
                          HomeTelNumber = m.HomeTelNumber,
                          FaxNumber = m.FaxNumber,
                          CelPhoneNumber = m.CelPhoneNumber,
                          DateCreated = m.DateCreated,
                          CreatedBy = m.CreatedBy,
                          DateModified = m.DateModified,
                          ModifiedBy = m.ModifiedBy,
                          PreferedLanguage = m.PreferedLanguage,
                          CommunicationMethod = m.CommunicationMethod,

                      }).SingleOrDefault();

            return sqlGet;
        }

        public string UpdateTeacherUserId(int id, string userId)
        {
            try
            {
                _schoolManagementDbConnector.TeacherData.Where(x => x.TeacherId == id).UpdateFromQuery(x => new TeacherData
                {
                    UserId = userId,
                    ModifiedBy = Roles.SystemAdmin.ToString()
                });
                return "OK";
            }
            catch (Exception ex)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }



        public string UpdateTeacherDetails(TeacherViewModel model)
        {
            try
            {
                _schoolManagementDbConnector.TeacherData.Where(x => x.TeacherId == model.TeacherId).UpdateFromQuery(x => new TeacherData
                {
                    Firstname = model.Firstname,
                    Midname = model.Midname,
                    Surname = model.Surname,
                    Title = model.Title,
                    Gender = model.Gender,
                    MaritalStatus = model.MaritalStatus,
                    IsSouthAfrican = model.IsSouthAfrican,
                    DateOfBirth = model.DateOfBirth,
                    IsActive = true,
                    HomeLanguage = model.HomeLanguage,
                    CountryOfBirth = model.CountryOfBirth,
                    PersonalEmailAddress = model.PersonalEmailAddress,
                    WorkTelNumber = model.WorkTelNumber,
                    HomeTelNumber = model.HomeTelNumber,
                    FaxNumber = model.FaxNumber,
                    CelPhoneNumber = model.CelPhoneNumber,
                    ModifiedBy = Roles.SystemAdmin.ToString(),
                    PreferedLanguage = model.PreferedLanguage,
                    CommunicationMethod = model.CommunicationMethod,
                });
                return HttpStatusCode.OK.ToString();
            }
            catch (Exception e)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }

        public string DeleteTeacher(int id)
        {
            try
            {
                _schoolManagementDbConnector.TeacherData.Where(x => x.TeacherId == id).UpdateFromQuery(x => new TeacherData
                {
                    IsActive = false
                });
                return HttpStatusCode.OK.ToString();
            }
            catch (Exception ex)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }
    }
}
