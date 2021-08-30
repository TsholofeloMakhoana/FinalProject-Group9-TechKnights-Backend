using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IModuleService
    {
        string CreateModule(ModuleViewModel model);
        List<ModuleViewModel> ListAllModule();
    }
}
