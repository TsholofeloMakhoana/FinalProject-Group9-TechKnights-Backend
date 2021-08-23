using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;


namespace SchoolManagementSystem.Feed
{
    public interface IParentRepository : IRepositoryBase<ParentData>
    {
    }

    public interface IParentAddressRepository : IRepositoryBase<ParentAddressData>
    {
    }
}
