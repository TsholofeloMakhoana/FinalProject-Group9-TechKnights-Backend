﻿using SchoolManagementSystem.Data;

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

        private ITeacherAddressRepository _teacherAddressData;
        public ITeacherAddressRepository TeacherAddressData => _teacherAddressData ??= new TeacherAddressRepository(_schoolManagementDbConnector);


        private IParentRepository _parentData;
        public IParentRepository ParentData => _parentData ??= new ParentRepository(_schoolManagementDbConnector);

        private IParentAddressRepository _parentAddressData;
        public IParentAddressRepository ParentAddressData => _parentAddressData ??= new ParentAddressRepository(_schoolManagementDbConnector);

        private IAddressRepository _addressData;
        public IAddressRepository AddressData => _addressData ??= new AddressRepository(_schoolManagementDbConnector);
        #endregion

        public int Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
