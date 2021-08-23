

namespace SchoolManagementSystem.Models
{
    public class TeacherData : GenericData
    {
        public int TeacherId { get; set; }
    }

    public class TeacherAddressData
    {
        public int TeacherAddressId { get; set; }
        public int TeacherId { get; set; }
        public int AddressId { get; set; }
    }
}
