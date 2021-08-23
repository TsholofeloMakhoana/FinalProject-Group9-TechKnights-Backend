
namespace SchoolManagementSystem.Models
{
    public class ParentData : GenericData
    {
        public int ParantId { get; set; }
    }
    public class ParentAddressData
    {
        public int ParentAddressId { get; set; }
        public int ParantId { get; set; }
        public int AddressId { get; set; }
    }
}
