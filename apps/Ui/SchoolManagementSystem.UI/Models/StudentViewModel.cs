using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.UI.Models
{
    public class StudentViewModel : SysGenericAddressViewModel
    {
        public string StudentNumber { get; set; }
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public bool IsSouthAfrican { get; set; }
        public string Saidnumber { get; set; }
        public string PassportNo { get; set; }
        public Guid CountryOfBirthId { get; set; }
        public Guid? HomeLanguageId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string WorkTelNumber { get; set; }
        public string HomeTelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CelPhoneNumber { get; set; }
        public string StudentPhoto { get; set; }
        public Guid ApplicationStatusId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; }
        public Guid? CommunicationMethodId { get; set; }
        public string Token { get; set; }
    }
}
