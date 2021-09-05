using Newtonsoft.Json;
using SchoolManagementSystem.Domain.Engine;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class ParentService : IParentService
    {

        #region ctor
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public ParentService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string CreateParent(ParentViewModel model)
        {
            try
            {
                if (_connectionWrapper.ParentData.IsParentExist(model.IdOrPassport))
                    return "Parent with the same ID/Passport already exist in the system";

                var modelValidation = GenericLogic.ValidateParentString(model);
                if (modelValidation == HttpStatusCode.OK.ToString())
                {
                    if (model.IsPostalSameAsPhysical == true)
                    {
                        GenericLogic.PhysicalEqualPostal(model);
                    }
                    var vModel = JsonConvert.DeserializeObject<ParentData>(JsonConvert.SerializeObject(model));
                    var createParent = _connectionWrapper.ParentData.Create(vModel);
                    if (createParent != null)
                    {
                        var address = JsonConvert.DeserializeObject<AddressData>(JsonConvert.SerializeObject(model));
                        var createAddress = _connectionWrapper.AddressData.Create(address);
                        if (createAddress != null)
                        {
                            var stdAddress = new ParentAddressData()
                            {
                                ParentId = createParent.ParentId,
                                AddressId = createAddress.AddressId
                            };
                            var saveAddresses = _connectionWrapper.ParentAddressData.Create(stdAddress);
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
            catch
            {
                return DatabaseErrors.ErrorOccured;
            }
            return null;
        }
    }

}
