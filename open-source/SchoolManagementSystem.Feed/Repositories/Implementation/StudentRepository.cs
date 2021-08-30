using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System.Linq;

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


        public List<StudentViewModel> GetAllStudents()
        {
            List<StudentViewModel> sqlGet = new List<StudentViewModel>();

            sqlGet = (from m in _schoolManagementDbConnector.StudentData
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
    }


    public class StudentAddressRepository : RepositoryBase<StudentAddressData>, IStudentAddressRepository
    {
        public StudentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
        }
    }
}
