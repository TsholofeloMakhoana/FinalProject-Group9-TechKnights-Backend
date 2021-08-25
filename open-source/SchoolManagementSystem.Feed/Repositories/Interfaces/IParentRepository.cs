using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IParentRepository : IRepositoryBase<ParentData>
    {
        List<ParentData> GetParents();
    }

    public interface IParentAddressRepository : IRepositoryBase<ParentAddressData>
    {
    }
}
