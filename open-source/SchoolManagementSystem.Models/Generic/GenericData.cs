using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    public class GenericData
    {
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }

        public bool IsSouthAfrican { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateOfBirth {get;set;} 
        public bool IsActive { get; set; }
        public string IdOrPassport { get; set; }
        public string HomeLanguage { get; set; }
        public string CountryOfBirth { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string WorkTelNumber { get; set; }
        public string HomeTelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CelPhoneNumber { get; set; }
        public string PreferedLanguage { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public int CommunicationMethod { get; set; }
    }
}
