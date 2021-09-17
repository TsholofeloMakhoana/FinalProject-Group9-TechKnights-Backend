

namespace SchoolManagementSystem.Notification
{
    public class TeacherNotificationHelper
    {
        public static void ParentNotification(string toEmail, string fullnames)
        {
            string dear = "Dear " + fullnames;

            string message = "<br/><br/><br/> You have been assigned to the system successfully.";

            const string endMessage = "<br/><br/>Thank you.<br/>The TechKnight Team";

            string mailBody = dear + message + endMessage;

            CustomHelpers.SendEmail(toEmail, mailBody, "System Notification");
        }
    }
}
