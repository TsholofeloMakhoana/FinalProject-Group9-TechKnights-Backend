using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SchoolManagementSystem.Feed
{
    public class StudentRepository : RepositoryBase<StudentData>, IStudentRepository
    {

        #region ctor
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public StudentRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }
        #endregion

     
       public StudentViewModel GetStudentByEmailAddress(string emailAddress)
        {
            var sqlGet = new StudentViewModel();
            sqlGet = (from m in _schoolManagementDbConnector.StudentData
                      where m.PersonalEmailAddress == emailAddress
                      join addr in _schoolManagementDbConnector.StudentAddressData on m.StudentId equals addr.StudentAddressId
                      join a in _schoolManagementDbConnector.AddressData on addr.AddressId equals a.AddressId
                      select new StudentViewModel
                      {
                          StudentId = m.StudentId,
                          StudentNumber = m.StudentNumber,
                          Firstname = m.Firstname,
                          Midname = m.Midname,
                          Surname = m.Surname,
                          Title = m.Title,
                          Gender = m.Gender,
                          IsDisable = m.IsDisable,
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
                          StudentPhoto = m.StudentPhoto,
                          ApplicationStatus = m.ApplicationStatus,
                          Token = m.Token,

                          AddressId = addr.AddressId,
                          PhysicalCountry = a.PhysicalCountry,
                          PhysicalProvince = a.PhysicalProvince,
                          PhysicalRegion = a.PhysicalRegion,
                          PhysicalCity = a.PhysicalCity,
                          PhysicalAddress = a.PhysicalAddress,
                          PhysicalAddressLine2 = a.PhysicalAddressLine2,
                          PhysicalAddressLine3 = a.PhysicalAddressLine3,
                          PhysicalOther = a.PhysicalOther,
                          PhysicalPostalCode = a.PhysicalPostalCode,
                          IsPostalSameAsPhysical = a.IsPostalSameAsPhysical,
                          PostalCountry = a.PostalCountry,
                          PostalProvince = a.PostalProvince,
                          PostalRegion = a.PostalRegion,
                          PostalCity = a.PostalCity,
                          PostalAddress = a.PostalAddress,
                          PostalOther = a.PostalOther,
                          PostalPostalCode = a.PostalPostalCode,
                          PostalAddressLine2 = a.PostalAddressLine2,
                          PostalAddressLine3 = a.PostalAddressLine3
                      }).SingleOrDefault();
            return sqlGet;
        }
        public StudentViewModel GetStudent(int id)
        {
            var sqlGet = new StudentViewModel();
            sqlGet = (from m in _schoolManagementDbConnector.StudentData
                      where m.StudentId == id
                      join addr in _schoolManagementDbConnector.StudentAddressData on m.StudentId equals addr.StudentAddressId
                      join a in _schoolManagementDbConnector.AddressData on addr.AddressId equals a.AddressId
                      select new StudentViewModel
                      {
                          StudentId = m.StudentId,
                          StudentNumber = m.StudentNumber,
                          Firstname = m.Firstname,
                          Midname = m.Midname,
                          Surname = m.Surname,
                          Title = m.Title,
                          Gender = m.Gender,
                          IsDisable = m.IsDisable,
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
                          StudentPhoto = m.StudentPhoto,
                          ApplicationStatus = m.ApplicationStatus,
                          Token = m.Token,

                          AddressId = addr.AddressId,
                          PhysicalCountry = a.PhysicalCountry,
                          PhysicalProvince = a.PhysicalProvince,
                          PhysicalRegion = a.PhysicalRegion,
                          PhysicalCity = a.PhysicalCity,
                          PhysicalAddress = a.PhysicalAddress,
                          PhysicalAddressLine2 = a.PhysicalAddressLine2,
                          PhysicalAddressLine3 = a.PhysicalAddressLine3,
                          PhysicalOther = a.PhysicalOther,
                          PhysicalPostalCode = a.PhysicalPostalCode,
                          IsPostalSameAsPhysical = a.IsPostalSameAsPhysical,
                          PostalCountry = a.PostalCountry,
                          PostalProvince = a.PostalProvince,
                          PostalRegion = a.PostalRegion,
                          PostalCity = a.PostalCity,
                          PostalAddress = a.PostalAddress,
                          PostalOther = a.PostalOther,
                          PostalPostalCode = a.PostalPostalCode,
                          PostalAddressLine2 = a.PostalAddressLine2,
                          PostalAddressLine3 = a.PostalAddressLine3
                      }).SingleOrDefault();
            return sqlGet;
        }

      
        public List<StudentViewModel> GetAllStudents()
        {
            List<StudentViewModel> sqlGet = new List<StudentViewModel>();

            sqlGet = (from m in _schoolManagementDbConnector.StudentData
                      join addr in _schoolManagementDbConnector.StudentAddressData on m.StudentId equals addr.StudentAddressId
                      join a in _schoolManagementDbConnector.AddressData on addr.AddressId equals a.AddressId
                      where m.IsActive == true
                      select new StudentViewModel
                      {
                          StudentId = m.StudentId,
                          StudentNumber = m.StudentNumber,
                          Firstname = m.Firstname,
                          Midname = m.Midname,
                          Surname = m.Surname,
                          Title = m.Title,
                          Gender = m.Gender,
                          IsDisable = m.IsDisable,
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
                          StudentPhoto = m.StudentPhoto,
                          ApplicationStatus = m.ApplicationStatus,
                          Token = m.Token,

                          AddressId = addr.AddressId,
                          PhysicalCountry = a.PhysicalCountry,
                          PhysicalProvince = a.PhysicalProvince,
                          PhysicalRegion = a.PhysicalRegion,
                          PhysicalCity = a.PhysicalCity,
                          PhysicalAddress = a.PhysicalAddress,
                          PhysicalAddressLine2 = a.PhysicalAddressLine2,
                          PhysicalAddressLine3 = a.PhysicalAddressLine3,
                          PhysicalOther = a.PhysicalOther,
                          PhysicalPostalCode = a.PhysicalPostalCode,
                          IsPostalSameAsPhysical = a.IsPostalSameAsPhysical,
                          PostalCountry = a.PostalCountry,
                          PostalProvince = a.PostalProvince,
                          PostalRegion = a.PostalRegion,
                          PostalCity = a.PostalCity,
                          PostalAddress = a.PostalAddress,
                          PostalOther = a.PostalOther,
                          PostalPostalCode = a.PostalPostalCode,
                          PostalAddressLine2 = a.PostalAddressLine2,
                          PostalAddressLine3 = a.PostalAddressLine3
                      }).ToList();
            return sqlGet;
        }
        public bool IsStudentExist(string studentPassportOrId)
        {
            var sCheck = from m in _schoolManagementDbConnector.StudentData
                         where m.IdOrPassport == studentPassportOrId
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }
        public bool IsEmailExist(string emailAddress)
        {
            var sCheck = from m in _schoolManagementDbConnector.StudentData
                         where m.PersonalEmailAddress == emailAddress
                         select m;
            if (sCheck.Any())
            {
                return true;
            }
            return false;
        }

        public string UpdateStudentDetails(StudentViewModel model)
        {
            try
            {
                _schoolManagementDbConnector.StudentData.Where(x => x.StudentId == model.StudentId).UpdateFromQuery(x => new StudentData
                {
                    Firstname = model.Firstname,
                    Midname = model.Midname,
                    Surname = model.Surname,
                    Title = model.Title,
                    Gender = model.Gender,
                    IsDisable = model.IsDisable,
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
            catch(Exception e)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }

        public string DeleteStudent(int id)
        {
            try
            {
                _schoolManagementDbConnector.StudentData.Where(x => x.StudentId == id).UpdateFromQuery(x => new StudentData
                {
                    IsActive = false                    
                });
                return HttpStatusCode.OK.ToString();
            }
            catch(Exception ex)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }
        public string UpdateUserId(int id, string userId)
        {
            try
            {
                _schoolManagementDbConnector.StudentData.Where(x => x.StudentId == id).UpdateFromQuery(x => new StudentData
                {
                    UserId = userId,
                    ApplicationStatus = Status.Approved.ToString(),
                    ModifiedBy = Roles.SystemAdmin.ToString()
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


    public class StudentAddressRepository : RepositoryBase<StudentAddressData>, IStudentAddressRepository
    {
        public StudentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
        }
    }
}
