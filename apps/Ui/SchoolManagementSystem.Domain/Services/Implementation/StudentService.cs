using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Notification;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class StudentService : IStudentService
    {
        #region ctor
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public StudentService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateStudent(StudentViewModel model)
        {
            try
            {
                if (_connectionWrapper.StudentData.IsStudentExist(model.IdOrPassport))
                    return "Student with the same ID/Passpoert already exist in the system";

                var modelValidation = GenericLogic.ValidateString(model);
                if (modelValidation == HttpStatusCode.OK.ToString())
                {
                    if (model.IsPostalSameAsPhysical == true)
                    {
                        GenericLogic.PhysicalEqualPostal(model);
                    }
                    model.MaritalStatus = null;
                    var vModel = JsonConvert.DeserializeObject<StudentData>(JsonConvert.SerializeObject(model));
                    var createStudent = _connectionWrapper.StudentData.Create(vModel);
                    if (createStudent != null)
                    {

                        var address = JsonConvert.DeserializeObject<AddressData>(JsonConvert.SerializeObject(model));
                        var createAddress = _connectionWrapper.AddressData.Create(address);
                        if (createAddress != null)
                        {
                            var stdAddress = new StudentAddressData()
                            {
                                StudentId = createStudent.StudentId,
                                AddressId = createAddress.AddressId
                            };
                            var saveAddresses = _connectionWrapper.StudentAddressData.Create(stdAddress);
                            if (saveAddresses != null)
                            {
                                string fullname = model.Firstname + " " + model.Surname;
                                StudentNotificationHelper.StudentInProgress(model.PersonalEmailAddress, fullname, model.StudentNumber);
                                return HttpStatusCode.OK.ToString();
                            }
                        }
                    }
                    else
                    {
                        return modelValidation;
                    }
                }
            }
            catch
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }


        public List<StudentViewModel> GetAllStudents()
        {
            return _connectionWrapper.StudentData.GetAllStudents();
        }

        public int StudentCount()
        {
            var stuCount = GetAllStudents().Count();
            if (stuCount > 0)
                return stuCount;
            return 0;
        }
    }
}
