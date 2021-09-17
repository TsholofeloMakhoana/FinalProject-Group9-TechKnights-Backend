

namespace SchoolManagementSystem.Feed
{
    public interface IRepositoryConnectionWrapper
    {
        #region Parent Teacher Student Data
        IStudentRepository StudentData { get; }
        IStudentAddressRepository StudentAddressData { get; }
        ITeacherRepository TeacherData { get; }
        IParentRepository ParentData { get; }   
        IAddressRepository AddressData { get; }
        #endregion


        IGradeRepository GradeData { get; }
        IModuleRepository ModuleData { get; }

        IEmailAuditRepository EmailAudit { get; }

        IInvoiceRepository InvoiceData { get; }
        int Save();
    }
}
