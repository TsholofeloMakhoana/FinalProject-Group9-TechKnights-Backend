
namespace SchoolManagementSystem.Models
{
    public class StudentData : GenericData
    {
        public int StudentId { get; set; }
        public string StudentNumber { get; set; } 
        public string StudentPhoto { get; set; }
        public int ApplicationStatusId { get; set; }  
        public string Token { get; set; }
    }

    public class StudentAddressData
    {
        public int StudentAddressId { get; set; }
        public int StudentId { get; set; }
        public int AddressId { get; set; }
    }
}
