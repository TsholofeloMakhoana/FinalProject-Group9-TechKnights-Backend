

using Newtonsoft.Json;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class InvoiceService : IInvoiceService
    {

        #region ctr
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public InvoiceService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion


        public List<InvoiceDataViewModel> GetInvoiceById(int id)
        {
            return _connectionWrapper.InvoiceData.GetInvoiceById(id);
        }
        public string CreateInvoice(InvoiceDataViewModel model)
        {
            try
            {
                var vModel = JsonConvert.DeserializeObject<InvoiceData>(JsonConvert.SerializeObject(model));
                if (_connectionWrapper.InvoiceData.Create(vModel) != null)
                {
                    return HttpStatusCode.OK.ToString();
                }
            }
            catch(Exception ex)
            {
                return DatabaseErrors.ErrorOccured + "--" + ex.Message;
            }
            return null;
        }
      
    }
}
