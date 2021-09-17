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

        public string IsStudentExist(string studentPassportOrId)
        {
            if (_connectionWrapper.StudentData.IsStudentExist(studentPassportOrId))
                return "Student with the same ID/Passport already exist in the system";
            return HttpStatusCode.OK.ToString();
        }

        public string IsEmailExist(string emailAddress)
        {
            if (_connectionWrapper.StudentData.IsStudentExist(emailAddress))
                return "Student with the same email address already exist in the system.";
            return HttpStatusCode.OK.ToString();
        }
        public string CreateStudent(StudentViewModel model)
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
                     
                        return createStudent.StudentId.ToString();
                    }
                }
            }
            return null;
        }      
        public List<StudentViewModel> GetAllStudents()
        {
            return _connectionWrapper.StudentData.GetAllStudents();
        }
        public StudentViewModel GetStudentById(int id)
        {
            return _connectionWrapper.StudentData.GetStudent(id);
        }

        public StudentViewModel GetStudentByEmailAddress(string emailAddress)
        {
            return _connectionWrapper.StudentData.GetStudentByEmailAddress(emailAddress);
        }
        public int StudentCount()
        {
            var stuCount = GetAllStudents().Count();
            if (stuCount > 0)
                return stuCount;
            return 0;
        }

        public string UpdateUserId(int id, string userId)
        {
            var get = _connectionWrapper.StudentData.UpdateUserId(id, userId);
            if (get != null)
            {
                return HttpStatusCode.OK.ToString();
            }
            return get;
        }

        public string UpdateStudentDetails(StudentViewModel model)
        {
            var update = _connectionWrapper.StudentData.UpdateStudentDetails(model);
            if (update == HttpStatusCode.OK.ToString())
            {
                return update;
            }
            return update;
        }
        public string DeleteStudent(int id)
        {
            var update = _connectionWrapper.StudentData.DeleteStudent(id);
            if (update == HttpStatusCode.OK.ToString())
            {
                return update;
            }
            return update;
        }
    }
}
