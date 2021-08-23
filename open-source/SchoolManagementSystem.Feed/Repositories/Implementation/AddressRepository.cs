using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Feed
{
    public class AddressRepository : RepositoryBase<AddressData>, IAddressRepository
    {
        public AddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        { 
        }
    }
}
