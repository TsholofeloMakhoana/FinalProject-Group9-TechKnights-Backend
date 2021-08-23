using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;


namespace SchoolManagementSystem.Feed
{
    public class ParentRepository : RepositoryBase<ParentData>, IParentRepository
    {
        public ParentRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }

    public class ParentAddressRepository : RepositoryBase<ParentAddressData>, IParentAddressRepository
    {
        public ParentAddressRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {

        }
    }
}
