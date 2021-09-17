
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class StudentData : GenericData
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentNumber { get; set; } 
        public string StudentPhoto { get; set; }
        public string IsDisable { get; set; }
        public string ApplicationStatus { get; set; }  
        public string Token { get; set; }
        public int GradeId { get; set; }
        public int ParentId { get; set; }
    }

    public class StudentAddressData
    {
        [Key]
        public int StudentAddressId { get; set; }
        public int StudentId { get; set; }
        public int AddressId { get; set; }
    }
}
