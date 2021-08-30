

namespace SchoolManagementSystem.Feed
{
    public interface IRepositoryConnectionWrapper
    {
        #region Parent Teacher Student Data
        IStudentRepository StudentData { get; }
        IStudentAddressRepository StudentAddressData { get; }
        ITeacherRepository TeacherData { get; }
        ITeacherAddressRepository TeacherAddressData { get; }
        IParentRepository ParentData { get; }
        IParentAddressRepository ParentAddressData { get; }
        IAddressRepository AddressData { get; }
        #endregion

        IGradeRepository GradeData { get; }
        IModuleRepository ModuleData { get; }
        int Save();
    }
}
