using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Feed
{
    public class RepositoryConnectionWrapper : IRepositoryConnectionWrapper
    {

        #region ctr
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public RepositoryConnectionWrapper(SchoolManagementDbConnector schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }
        #endregion

        #region Parent Teacher Student
        private IStudentRepository _studentData;
        public IStudentRepository StudentData => _studentData ??= new StudentRepository(_schoolManagementDbConnector);
        
        private IStudentAddressRepository _studentAddressData;
        public IStudentAddressRepository StudentAddressData => _studentAddressData ??= new StudentAddressRepository(_schoolManagementDbConnector);


        private ITeacherRepository _teacherData;
        public ITeacherRepository TeacherData => _teacherData ??= new TeacherRepository(_schoolManagementDbConnector);
               

        private IParentRepository _parentData;
        public IParentRepository ParentData => _parentData ??= new ParentRepository(_schoolManagementDbConnector);

      
        private IAddressRepository _addressData;
        public IAddressRepository AddressData => _addressData ??= new AddressRepository(_schoolManagementDbConnector);
        #endregion



        private IGradeRepository _gradeData;
        public IGradeRepository GradeData => _gradeData ??= new GradeRepository(_schoolManagementDbConnector);

        private IModuleRepository _moduleData;
        public IModuleRepository ModuleData => _moduleData ??= new ModuleRepository(_schoolManagementDbConnector);

        private IEmailAuditRepository _emailAudit;
        public IEmailAuditRepository EmailAudit => _emailAudit ??= new EmailAuditRepository(_schoolManagementDbConnector);


        private IInvoiceRepository _invoiceData;
        public IInvoiceRepository InvoiceData => _invoiceData ??= new InvoiceRepository(_schoolManagementDbConnector);


        public int Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
