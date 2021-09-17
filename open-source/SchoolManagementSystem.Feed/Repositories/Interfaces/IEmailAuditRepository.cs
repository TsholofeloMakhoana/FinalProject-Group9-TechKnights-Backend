using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Feed
{
    public interface IEmailAuditRepository :  IRepositoryBase<EmailAuditData>
    {
        List<EmailAuditDataViewModel> GetEmails(string mailTo, string role);
    }
}
