

using SchoolManagementSystem.Domain.Data;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IParentService
    {
        string CreateParent(ParentViewModel model);
    }
}
