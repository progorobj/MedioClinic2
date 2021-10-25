using Business.Models;
using System.ComponentModel;



namespace Identity.Models.Account
{
    public class SignInViewModel
    {
        public EmailViewModel EmailViewModel { get; set; } = new EmailViewModel();

        public PasswordViewModel PasswordViewModel { get; set; } = new PasswordViewModel();

        [DisplayName("Identity.Account.StaySignedIn")]
        public bool StaySignedIn { get; set; }
    }
}