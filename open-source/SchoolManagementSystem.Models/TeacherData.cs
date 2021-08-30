

using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class TeacherData : GenericData
    {
        [Key]
        public int TeacherId { get; set; }
        public string MaritalStatus { get; set; }
    }

    public class TeacherAddressData
    {
        [Key]
        public int TeacherAddressId { get; set; }
        public int TeacherId { get; set; }
        public int AddressId { get; set; }
    }
}
