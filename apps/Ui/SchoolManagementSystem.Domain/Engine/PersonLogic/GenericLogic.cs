using SchoolManagementSystem.Domain.Data;


namespace SchoolManagementSystem.Domain.Engine
{
    public class GenericLogic
    {
        public static string ValidateString(StudentViewModel model)
        {
            if (string.IsNullOrEmpty(model.genericViewModel.Firstname))
                return "Please provide firstname.";
            if (string.IsNullOrEmpty(model.genericViewModel.Surname))
                return "Please provide surname.";
            if (string.IsNullOrEmpty(model.genericViewModel.CelPhoneNumber))
                return "Please provide cellphone";
            if (string.IsNullOrEmpty(model.genericViewModel.IdOrPassport))               
                return "Please provide ID Number or Passport";
            if (string.IsNullOrEmpty(model.genericViewModel.Firstname))
                return "Please provide firstname";

            return "Ok";
        }
    }
}
