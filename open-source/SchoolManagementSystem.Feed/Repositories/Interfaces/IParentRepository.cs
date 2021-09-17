using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IParentRepository : IRepositoryBase<ParentData>
    {       
        bool IsEmailExist(string emailAddress);
        bool IsParentExist(string PassportOrId);
        ParentViewModel GetParent(int id);
        List<ParentViewModel> GetAllParents();
        string UpdateParentUserId(int id, string userId);

        string DeleteParent(int id);
        string UpdateParentDetails(ParentViewModel model);
    }
}
