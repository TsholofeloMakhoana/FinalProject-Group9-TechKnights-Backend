using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IParentRepository : IRepositoryBase<ParentData>
    {
        bool IsParentExist(string PassportOrId);
        ParentViewModel GetParent(int id);
        List<ParentViewModel> GetAllParents();
    }

    public interface IParentAddressRepository : IRepositoryBase<ParentAddressData>
    {
    }
}
