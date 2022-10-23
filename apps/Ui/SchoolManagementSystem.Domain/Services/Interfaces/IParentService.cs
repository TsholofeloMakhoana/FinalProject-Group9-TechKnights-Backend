

using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IParentService
    {
        string IsParentExist(string studentPassportOrId);
        string IsEmailExist(string emailAddress);
        string CreateParent(ParentViewModel model);
        ParentViewModel GetParent(int id);
        List<ParentViewModel> GetAllParents();
        int ParentCount();

        string UpdateParentUserId(int id, string userId);

        string DeleteParent(int id);
        string UpdateParentDetails(ParentViewModel model);
    }
}
