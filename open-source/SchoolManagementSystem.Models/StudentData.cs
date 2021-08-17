

namespace SchoolManagementSystem.Models
{
    public class StudentData : GenericData
    {
        public int StudentId { get; set; }
    }

    public class StudentAddressData
    {
        public int StudentAddressId { get; set; }
        public int StudentId { get; set; }
        public int AddressId { get; set; }
    }
}
