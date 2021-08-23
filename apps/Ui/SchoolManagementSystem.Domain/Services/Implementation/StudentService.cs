using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Data;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;


namespace SchoolManagementSystem.Domain.Services
{
    public class StudentService : IStudentService
    {


        #region ctr
        private readonly RepositoryConnectionWrapper _connectionWrapper;
        public StudentService(RepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateStudent(StudentViewModel model)
        {          
            try
            {
                var modelValidation = GenericLogic.ValidateString(model);
                if (modelValidation != "OK")
                {
                    var vModel = JsonConvert.DeserializeObject<StudentData>(JsonConvert.SerializeObject(model));
                    var createStudent = _connectionWrapper.StudentData.Create(vModel);
                    if (createStudent != null)
                    {
                        var addressModel = JsonConvert.DeserializeObject<AddressData>(JsonConvert.SerializeObject(vModel));
                        int saveStudent = _connectionWrapper.Save();
                        if (saveStudent > 0)
                        {
                            var createAddress = _connectionWrapper.AddressData.Create(addressModel);
                            if (createAddress != null)
                            {
                                int saveAddress = _connectionWrapper.Save();
                                if (saveAddress > 0)
                                {
                                    var stdAddress = new StudentAddressData()
                                    {
                                        StudentId = createStudent.StudentId,
                                        AddressId = createAddress.AddressId
                                    };                                    
                                    var saveAddresses = _connectionWrapper.StudentAddressData.Create(stdAddress);
                                    if (_connectionWrapper.Save() > 0 && saveAddresses != null)
                                    {
                                        return "New student has been added successfully.";
                                    }
                                }
                            }
                        }
                    }
                }else
                {
                    return modelValidation;
                }
            }
            catch(Exception ex)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }
    }

}
