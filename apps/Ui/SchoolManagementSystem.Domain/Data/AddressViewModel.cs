

namespace SchoolManagementSystem.Domain.Data
{
    public class AddressViewModel
    {
        public int AddressId { get; set; }
        public string PhysicalCountry { get; set; }
        public string PhysicalProvince { get; set; }
        public string PhysicalRegion { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalAddress { get; set; }
        public string PhysicalAddressLine2 { get; set; }
        public string PhysicalAddressLine3 { get; set; }
        public string PhysicalOther { get; set; }
        public string PhysicalPostalCode { get; set; }
        public bool? IsPostalSameAsPhysical { get; set; }
        public string PostalCountry { get; set; }
        public string PostalProvince { get; set; }
        public string PostalRegion { get; set; }
        public string PostalCity { get; set; }
        public string PostalAddress { get; set; }
        public string PostalOther { get; set; }
        public string PostalPostalCode { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalAddressLine3 { get; set; }
    }
}
