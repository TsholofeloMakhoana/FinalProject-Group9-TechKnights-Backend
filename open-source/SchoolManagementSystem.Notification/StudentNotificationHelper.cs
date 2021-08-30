
namespace SchoolManagementSystem.Notification
{
    public class StudentNotificationHelper
    {
        public static void StudentInProgress(string toEmail, string fullnames, string studentNum)
        {
            string dear = "Dear "+ fullnames;

            string message = "<br/><br/><br/> We recieved you application successfully.";
            string status = "<br/><br/><br/> Your application it's in progress status and here is your new student number" + studentNum;
            const string endMessage = "<br/><br/>Thank you.<br/>The TechKnight Team";          

            string mailBody =  dear + message + studentNum + status + endMessage;

            CustomHelpers.SendEmail(toEmail, mailBody, "TechKnight Application Status : InProgress");
        }
    }
}
