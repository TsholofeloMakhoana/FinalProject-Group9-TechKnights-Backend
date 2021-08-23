

namespace SchoolManagementSystem.Feed
{
    public interface IRepositoryConnectionWrapper
    {
        IStudentRepository StudentData { get; }
        IStudentAddressRepository StudentAddressData { get; }
        ITeacherRepository TeacherData { get; }
        ITeacherAddressRepository TeacherAddressData { get; }
        IParentRepository ParentData { get; }
        IParentAddressRepository ParentAddressData { get; }
        IAddressRepository AddressData { get; }

        int Save();
    }
}
