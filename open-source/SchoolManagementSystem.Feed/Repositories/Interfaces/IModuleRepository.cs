
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IModuleRepository : IRepositoryBase<ModuleData>
    {
        List<ModuleViewModel> GetAllModule();
    }
}
