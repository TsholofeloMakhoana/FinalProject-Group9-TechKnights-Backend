using SchoolManagementSystem.Domain.Data;


namespace SchoolManagementSystem.Domain.Engine
{
    public class GenericLogic
    {
        public static string ValidateString(GenericViewModel model)
        {
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname.";
            if (string.IsNullOrEmpty(model.Surname))
                return "Please provide surname.";
            if (string.IsNullOrEmpty(model.CelPhoneNumber))
                return "Please provide cellphone";
            if (string.IsNullOrEmpty(model.IdOrPassport))               
                return "Please provide ID Number or Passport";
            if (string.IsNullOrEmpty(model.Firstname))
                return "Please provide firstname";

            return "Ok";
        }
    }
}
