using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Data;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly RepositoryConnectionWrapper _connectionWrapper;
        public TeacherService(RepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }

        public string CreateTeacher(TeacherViewModel model)
        {
            try
            {
                var modelValidation = GenericLogic.ValidateString(null);
                if (modelValidation != "OK")
                {
                    var vModel = JsonConvert.DeserializeObject<TeacherData>(JsonConvert.SerializeObject(model));
                    var createTeacher= _connectionWrapper.TeacherData.Create(vModel);
                    if (createTeacher != null)
                    {
                        var addressModel = JsonConvert.DeserializeObject<AddressData>(JsonConvert.SerializeObject(vModel));
                        int saveTeacher= _connectionWrapper.Save();
                        if (saveTeacher > 0)
                        {
                            var createAddress = _connectionWrapper.AddressData.Create(addressModel);
                            if (createAddress != null)
                            {
                                int saveAddress = _connectionWrapper.Save();
                                if (saveAddress > 0)
                                {
                                    var stdAddress = new TeacherAddressData()
                                    {
                                        TeacherId = createTeacher.TeacherId,
                                        AddressId = createAddress.AddressId
                                    };
                                    var saveAddresses = _connectionWrapper.TeacherAddressData.Create(stdAddress);
                                    if (_connectionWrapper.Save() > 0 && saveAddresses != null)
                                    {
                                        return "New student has been added successfully.";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    return modelValidation;
                }
            }
            catch (Exception ex)
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
    }
}
