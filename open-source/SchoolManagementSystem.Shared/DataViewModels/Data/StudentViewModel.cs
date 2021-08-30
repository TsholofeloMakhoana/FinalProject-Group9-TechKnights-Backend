using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Shared
{
    public class StudentViewModel : AddressViewModel
    {
        public int StudentId { get; set; }
        public string StudentNumber { get; set; }
        public string StudentPhoto { get; set; }
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string PreferedLanguage { get; set; }
        public string CountryOfBirth { get; set; }
        public string IsDisable { get; set; }
        //toremove
        public string MaritalStatus { get; set; } = null;
        public bool IsSouthAfrican { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public string IdOrPassport { get; set; }
        public string HomeLanguage { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string WorkTelNumber { get; set; }
        public string HomeTelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CelPhoneNumber { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public int CommunicationMethod { get; set; }
        public string ApplicationStatus { get; set; }
        public string Token { get; set; }
    }

    public class StudentAddressViewModel
    {
        public int StudentAddressId { get; set; }
        public int StudentId { get; set; }
        public int AddressId { get; set; }
    }
}
