using SchoolManagementSystem.Feed;

namespace SchoolManagementSystem.Domain.Services
{
    public class AddressService : IAddressService
    {
        private readonly RepositoryConnectionWrapper _connectionWrapper;        
        public AddressService(RepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
    }
}
