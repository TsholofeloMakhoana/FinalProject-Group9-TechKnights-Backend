using SchoolManagementSystem.Shared;
using System.Net;

namespace SchoolManagementSystem.Domain.Engine
{
    public class GenericLogic
    {
        public static string ValidateString(StudentViewModel model)
        {
            if (model.GradeId < 0)
                return "Please select student grade.";
            if (model.ParentId < 0)
                return "Please select student Parent.";
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname.";
            if (string.IsNullOrEmpty(model.Surname))
                return "Please provide surname.";
            if (string.IsNullOrEmpty(model.CelPhoneNumber))
                return "Please provide cellphone";
            if (string.IsNullOrEmpty(model.IdOrPassport))
                return "Please provide ID Number or Passport";
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname";
            if (model.Gender is null)
                return "Please select gender";
            if (model.CountryOfBirth is null)
                return "Please select Country of Birth";
            if (model.Title is null)
                return "Please Select Title";
            if (model.PreferedLanguage is null)
                return "Please select Prefered Language";
            if (model.CommunicationMethod is null)
                return "Please select Communication Method";        

            return HttpStatusCode.OK.ToString();
        }
        public static string ValidateParentString(ParentViewModel model)
        {
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname.";
            if (string.IsNullOrEmpty(model.Surname))
                return "Please provide surname.";
            if (string.IsNullOrEmpty(model.CelPhoneNumber))
                return "Please provide cellphone";
            if (string.IsNullOrEmpty(model.IdOrPassport))
                return "Please provide ID Number or Passport";
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname";
            if (model.Gender is null)
                return "Please select gender";
            if (model.CountryOfBirth is null)
                return "Please select Country of Birth";
            if (model.Title is null)
                return "Please Select Title";
            if (model.PreferedLanguage is null)
                return "Please select Prefered Language";
            if (model.CommunicationMethod is null)
                return "Please select Communication Method";
            return HttpStatusCode.OK.ToString();
        }

        public static string ValidateTeacherString(TeacherViewModel model)
        {
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname.";
            if (string.IsNullOrEmpty(model.Surname))
                return "Please provide surname.";
            if (string.IsNullOrEmpty(model.CelPhoneNumber))
                return "Please provide cellphone";
            if (string.IsNullOrEmpty(model.IdOrPassport))
                return "Please provide ID Number or Passport";
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname";
            if (model.Gender is null)
                return "Please select gender";
            if (model.CountryOfBirth is null)
                return "Please select Country of Birth";
            if (model.Title is null)
                return "Please Select Title";
            if (model.PreferedLanguage is null)
                return "Please select Prefered Language";
            if (model.CommunicationMethod is null)
                return "Please select Communication Method";
            return HttpStatusCode.OK.ToString();
        }
        public static void PhysicalEqualPostal(AddressViewModel model)
        {

            model.PostalCountry = model.PhysicalCountry;
            model.PostalProvince = model.PhysicalProvince;
            model.PostalRegion = model.PhysicalRegion;
            model.PostalCity = model.PhysicalCity;
            model.PostalAddress = model.PhysicalAddress;
            model.PostalAddressLine2 = model.PhysicalAddressLine2;
            model.PostalAddressLine3 = model.PhysicalAddressLine3;
            model.PostalOther = model.PhysicalOther;
            model.PostalPostalCode = model.PhysicalPostalCode;
        }

        public static AddressViewModel AddressMapping(AddressViewModel model)
        {
            var addressModel = new AddressViewModel()
            {
                PhysicalCountry = model.PhysicalCountry,
                PhysicalProvince = model.PhysicalProvince,
                PhysicalRegion = model.PhysicalRegion,
                PhysicalCity = model.PhysicalCity,
                PhysicalAddress = model.PhysicalAddress,
                PhysicalAddressLine2 = model.PhysicalAddressLine2,
                PhysicalAddressLine3 = model.PhysicalAddressLine3,
                PhysicalOther = model.PhysicalOther,
                PhysicalPostalCode = model.PhysicalPostalCode,

                PostalCountry = model.PostalAddress,
                PostalProvince = model.PostalProvince,
                PostalRegion = model.PostalRegion,
                PostalCity = model.PostalCity,
                PostalAddress = model.PostalAddress,
                PostalAddressLine2 = model.PostalAddressLine2,
                PostalAddressLine3 = model.PostalAddressLine3,
                PostalOther = model.PostalOther,
                PostalPostalCode = model.PostalPostalCode,
            };
            return addressModel;
        }
    }
}
