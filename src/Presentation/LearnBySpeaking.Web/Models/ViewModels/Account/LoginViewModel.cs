using System.ComponentModel.DataAnnotations;

namespace LearnBySpeaking.Web.Models.ViewModels.Account
{
    public class LoginViewModel
    {
        [MinLength(4),MaxLength(45)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}