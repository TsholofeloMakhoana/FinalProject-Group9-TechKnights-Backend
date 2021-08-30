using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;


namespace SchoolManagementSystem.Notification
{
    public class CustomHelpers
    {
        internal static void SendEmail(string toEmail, string body, string subject)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(toEmail));
            message.From = new MailAddress("##");
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            var credential = new NetworkCredential
            {
                UserName = "####",
                Password = "##"
            };
            var smtp = new SmtpClient
            {
                Credentials = credential,
                Host = "smtp.gmail.com",
                Port = Convert.ToInt32("587"),
                EnableSsl = true
            };

            smtp.SendCompleted += (sender, error) =>
            {
                try
                {
                    if (error.Error != null)
                    {
                    }
                    smtp.Dispose();
                    message.Dispose();
                }
                catch (Exception)
                {

                }

            };
            ThreadPool.QueueUserWorkItem(o => smtp.SendAsync(message, Tuple.Create(smtp, message)));
        }

    }
}
