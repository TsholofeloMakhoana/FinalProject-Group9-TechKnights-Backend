

using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class TeacherData : GenericData
    {
        [Key]
        public int TeacherId { get; set; }
        public string MaritalStatus { get; set; }
    }
}
