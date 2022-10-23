
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class ParentData : GenericData
    {
        [Key]
        public int ParentId { get; set; }
        public string MaritalStatus { get; set; }
    }   
}
