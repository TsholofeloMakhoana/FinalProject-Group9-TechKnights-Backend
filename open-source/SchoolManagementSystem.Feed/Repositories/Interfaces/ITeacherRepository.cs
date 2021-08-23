using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Feed
{
    public interface ITeacherRepository : IRepositoryBase<TeacherData>
    {
    }

    public interface ITeacherAddressRepository : IRepositoryBase<TeacherAddressData>
    {
    }
}
