
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class ParentData : GenericData
    {
        [Key]
        public int ParentId { get; set; }
        public string MaritalStatus { get; set; }
    }
    public class ParentAddressData
    {
        [Key]
        public int ParentAddressId { get; set; }
        public int ParantId { get; set; }
        public int AddressId { get; set; }
    }
}
