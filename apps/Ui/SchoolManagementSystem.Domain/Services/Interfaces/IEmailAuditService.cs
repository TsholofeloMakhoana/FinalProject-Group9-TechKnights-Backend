
using SchoolManagementSystem.Shared;
using System.Collections.Generic;

namespace SchoolManagementSystem.Domain.Services
{
    public interface IEmailAuditService
    {
        string SendEmail(int Id, string EmailSubject, string Mailto, string MailFrom, string Body, string DearName, string sendToType);

        List<EmailAuditDataViewModel> GetEmails(string mailTo, string role);
    }
}
