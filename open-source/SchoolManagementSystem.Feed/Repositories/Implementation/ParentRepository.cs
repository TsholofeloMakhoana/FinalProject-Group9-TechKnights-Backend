using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SchoolManagementSystem.Feed
{
    public class ParentRepository : RepositoryBase<ParentData>, IParentRepository
    {
        public SchoolManagementDbConnector _schoolManagementDbConnector;
        public ParentRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }

        public bool IsParentExist(string PassportOrId)
        {
            var sCheck = from m in _schoolManagementDbConnector.ParentData
                         where m.IdOrPassport == PassportOrId
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }
        public bool IsEmailExist(string emailAddress)
        {
            var sCheck = from m in _schoolManagementDbConnector.ParentData
                         where m.PersonalEmailAddress == emailAddress
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }
        public ParentViewModel GetParent(int id)
        {
            var sqlGet = new ParentViewModel();

            sqlGet = (from m in _schoolManagementDbConnector.ParentData
                      where m.ParentId == id                     
                      select new ParentViewModel
                      {
                          ParentId = m.ParentId,
                          Firstname = m.Firstname,
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

                      }).FirstOrDefault();
            return sqlGet;
        }
        public List<ParentViewModel> GetAllParents()
        {
            List<ParentViewModel> sqlGet = new List<ParentViewModel>();

            sqlGet = (from m in _schoolManagementDbConnector.ParentData
                      where m.IsActive == true
                      select new ParentViewModel
                      {
                          ParentId = m.ParentId,
                          Firstname = m.Firstname,
                          Midname = m.Midname,
                          FullNames = m.Firstname +" "+m.Surname +" ID/Passport: "+ m.IdOrPassport,
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
        public string UpdateParentUserId(int id, string userId)
        {
            try
            {
                _schoolManagementDbConnector.ParentData.Where(x => x.ParentId == id).UpdateFromQuery(x => new ParentData
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

        public string UpdateParentDetails(ParentViewModel model)
        {
            try
            {
                _schoolManagementDbConnector.ParentData.Where(x => x.ParentId == model.ParentId).UpdateFromQuery(x => new ParentData
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

        public string DeleteParent(int id)
        {
            try
            {
                _schoolManagementDbConnector.ParentData.Where(x => x.ParentId == id).UpdateFromQuery(x => new ParentData
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
