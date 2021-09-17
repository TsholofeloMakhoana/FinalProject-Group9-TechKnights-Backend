using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Feed
{
    public class EmailAuditRepository : RepositoryBase<EmailAuditData>, IEmailAuditRepository
    {
        #region ctor
        private readonly SchoolManagementDbConnector _schoolManagementDbConnector;
        public EmailAuditRepository(SchoolManagementDbConnector schoolManagementDbConnector) : base(schoolManagementDbConnector)
        {
            _schoolManagementDbConnector = schoolManagementDbConnector;
        }
        #endregion

        public List<EmailAuditDataViewModel> GetEmails(string mailTo, string role)
        {
            return (from m in _schoolManagementDbConnector.EmailAuditData
                    where m.Mailto == mailTo && m.SentToSystemRole == role
                    select new EmailAuditDataViewModel
                    {
                        EmailAuditId = m.EmailAuditId,
                        Mailto = m.Mailto,
                        MailFrom = m.MailFrom,
                        EmailSubject = m.EmailSubject,
                        Body = m.Body,
                        DearName = m.DearName,
                        SentToSystemRole = m.SentToSystemRole,
                        Id = m.Id,
                        CreatedBy = m.CreatedBy
                    }).ToList();
        }
    }
}
