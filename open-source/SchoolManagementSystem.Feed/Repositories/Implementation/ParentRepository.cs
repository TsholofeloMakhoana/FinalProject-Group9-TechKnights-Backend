using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;
using System.Linq;

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
        public ParentViewModel GetParent(int id)
        {
            var sqlGet = new ParentViewModel();

            sqlGet = (from m in _schoolManagementDbConnector.ParentData
                      where m.ParentId == id
                      join addr in _schoolManagementDbConnector.ParentAddressData on m.ParentId equals addr.ParentAddressId
                      join a in _schoolManagementDbConnector.AddressData on addr.AddressId equals a.AddressId
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
                      }).FirstOrDefault();
            return sqlGet;
        }
        public List<ParentViewModel> GetAllParents()
        {
            List<ParentViewModel> sqlGet = new List<ParentViewModel>();

            sqlGet = (from m in _schoolManagementDbConnector.ParentData
                    
                      join addr in _schoolManagementDbConnector.ParentAddressData on m.ParentId equals addr.ParentAddressId
                      join a in _schoolManagementDbConnector.AddressData on addr.AddressId equals a.AddressId
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
        public int TeacherCount()
        {
            return GetAllParents().Count();
        }
    }

    public class ParentAddressRepository : RepositoryBase<ParentAddressData>, IParentAddressRepository
    {
        public ParentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }
}
