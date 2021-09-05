using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public TeacherService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }

        public string CreateTeacher(TeacherViewModel model)
        {
            try
            {
                if (_connectionWrapper.TeacherData.IsTeacherExist(model.IdOrPassport))
                    return "Teacher with the same ID/Passport already exist in the system";

                var modelValidation = GenericLogic.ValidateTeacherString(model);
                if (modelValidation == HttpStatusCode.OK.ToString())
                {
                    if (model.IsPostalSameAsPhysical == true)
                    {
                        GenericLogic.PhysicalEqualPostal(model);
                    }
                    var vModel = JsonConvert.DeserializeObject<TeacherData>(JsonConvert.SerializeObject(model));
                    var createTeacher= _connectionWrapper.TeacherData.Create(vModel);
                    if (createTeacher != null)
                    {
                        var address = JsonConvert.DeserializeObject<AddressData>(JsonConvert.SerializeObject(model));
                        var createAddress = _connectionWrapper.AddressData.Create(address);
                        if (createAddress != null)
                        {
                            var stdAddress = new TeacherAddressData()
                            {
                                TeacherId = createTeacher.TeacherId,
                                AddressId = createAddress.AddressId
                            };
                            var saveAddresses = _connectionWrapper.TeacherAddressData.Create(stdAddress);
                            if (saveAddresses != null)
                            {
                                string fullname = model.Firstname + " " + model.Surname;
                                //StudentNotificationHelper.StudentInProgress(model.PersonalEmailAddress, fullname, model.StudentNumber);
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
            catch(Exception ex)
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }

        public List<TeacherViewModel> GetTeachers()
        {
            try
            {
             // var getTeacher = 

            }
            catch(Exception ex)
            {
                return null;
            }
            return null;
        }

        public int TeacherCount()
        {
            var teaCount = GetTeachers().Count();
            if (teaCount > 0)
                return teaCount;
            return 0;
        }
    }
}
