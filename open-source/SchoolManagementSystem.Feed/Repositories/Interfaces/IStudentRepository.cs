using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Feed
{
    public interface IStudentRepository : IRepositoryBase<StudentData>
    {

    }

    public interface IStudentAddressRepository : IRepositoryBase<StudentAddressData>
    {

    }
}
