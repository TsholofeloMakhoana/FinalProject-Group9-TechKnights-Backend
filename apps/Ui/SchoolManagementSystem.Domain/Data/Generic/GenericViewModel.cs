


using System;

namespace SchoolManagementSystem.Domain.Data
{
    public class GenericViewModel
    {
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public bool IsSouthAfrican { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public string IdOrPassport { get; set; }    
        public string HomeLanguage { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string WorkTelNumber { get; set; }
        public string HomeTelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CelPhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public int CommunicationMethodId { get; set; }
    }
}
