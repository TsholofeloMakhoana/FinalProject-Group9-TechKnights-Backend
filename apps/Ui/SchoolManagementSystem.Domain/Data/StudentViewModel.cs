

namespace SchoolManagementSystem.Domain.Data
{
    public class StudentViewModel : AddressViewModel
    {
        public int StudentId { get; set; }
        public string StudentNumber { get; set; }
        public string StudentPhoto { get; set; }
        public int ApplicationStatusId { get; set; }
        public string Token { get; set; }
        public GenericViewModel genericViewModel { get; set; } 
    }

    public class StudentAddressViewModel
    {
        public int StudentAddressId { get; set; }
        public int StudentId { get; set; }
        public int AddressId { get; set; }
    }
}
