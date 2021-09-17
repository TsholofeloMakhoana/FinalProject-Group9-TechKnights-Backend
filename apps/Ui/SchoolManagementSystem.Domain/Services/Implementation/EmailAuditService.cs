using Newtonsoft.Json;
using SchoolManagementSystem.Feed;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Net;

namespace SchoolManagementSystem.Domain.Services
{
    public class EmailAuditService : IEmailAuditService
    {

        #region ctr
        private readonly IRepositoryConnectionWrapper _connectionWrapper;
        public EmailAuditService(IRepositoryConnectionWrapper connectionWrapper)
        {
            _connectionWrapper = connectionWrapper;
        }
        #endregion

        public string SendEmail(int Id, string EmailSubject, string Mailto,string MailFrom,string Body,string DearName, string sendToType)
        {
            try
            {
                var model = new EmailAuditDataViewModel
                {
                    Mailto = Mailto,
                    EmailSubject = EmailSubject,
                    MailFrom = MailFrom,
                    DearName = DearName,
                    Body = Body,
                    Id = Id,
                    SentToSystemRole = sendToType,
                    CreatedBy = Roles.SystemAdmin.ToString()
                };                
                var vModel = JsonConvert.DeserializeObject<EmailAuditData>(JsonConvert.SerializeObject(model));
                if (_connectionWrapper.EmailAudit.Create(vModel) != null)
                {
                    return HttpStatusCode.OK.ToString();
                }
            }
            catch (Exception ex)
            {
                return DatabaseErrors.ErrorOccured + "--" + ex.Message;
            }
            return null;
        }

        public List<EmailAuditDataViewModel> GetEmails(string mailTo, string role)
        {
            return _connectionWrapper.EmailAudit.GetEmails(mailTo, role);
        }
    }
}
