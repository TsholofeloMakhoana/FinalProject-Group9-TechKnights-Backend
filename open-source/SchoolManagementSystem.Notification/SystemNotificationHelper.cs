


namespace SchoolManagementSystem.Notification
{
   public class SystemNotificationHelper
    {
        public static void ResetPassword(string toEmail, string fullnames, string messagepass)
        {
            string dear = "Dear " + fullnames;
            string message = "<br/> We recieved your password reset email.<br/><br/>";
            const string endMessage = "<br/><br/>Thank you.<br/>The TechKnight Team";

            string mailBody = dear + message + messagepass +  endMessage;

            CustomHelpers.SendEmail(toEmail, mailBody, "Reset Password");
        }

        public static void ConfirmRegistration(string toEmail, string fullnames, string messagepass, string loginDetails)
        {
            string dear = "Dear " + fullnames;
            string message = "<br/><br/> Registration confirmation.<br/><br/>";
            const string endMessage = "<br/><br/>Thank you.<br/>The TechKnight Team";

            string mailBody = dear + message + loginDetails + messagepass + endMessage;

            CustomHelpers.SendEmail(toEmail, mailBody, "Confirm Account");
        }
    }
}
