using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Data;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;

namespace SchoolManagementSystem.Domain.Services
{
    public class ParentService : IParentService
    {
        private readonly RepositoryConnectionWrapper _connectionWrapper;
        public ParentService(RepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }

        public string CreateParent(ParentViewModel model)
        {
            try
            {
                var modelValidation = GenericLogic.ValidateString(null);
                if (modelValidation != "OK")
                {
                    var vModel = JsonConvert.DeserializeObject<ParentData>(JsonConvert.SerializeObject(model));
                    var createParent= _connectionWrapper.ParentData.Create(vModel);
                    if (createParent != null)
                    {
                        var addressModel = JsonConvert.DeserializeObject<AddressData>(JsonConvert.SerializeObject(vModel));
                        int saveTeacher = _connectionWrapper.Save();
                        if (saveTeacher > 0)
                        {
                            var createAddress = _connectionWrapper.AddressData.Create(addressModel);
                            if (createAddress != null)
                            {
                                int saveAddress = _connectionWrapper.Save();
                                if (saveAddress > 0)
                                {
                                    var stdAddress = new ParentAddressData()
                                    {
                                        ParantId = createParent.ParantId,
                                        AddressId = createAddress.AddressId
                                    };                                   
                                    var saveAddresses = _connectionWrapper.ParentAddressData.Create(stdAddress);
                                    if (_connectionWrapper.Save() > 0 && saveAddresses !=null)
                                    {
                                        return "New parent has been added successfully.";
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
    }

}
