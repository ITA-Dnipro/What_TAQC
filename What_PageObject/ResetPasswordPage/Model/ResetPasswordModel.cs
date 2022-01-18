namespace What_PageObject.ResetPasswordPage.Model
{
    public class ResetPasswordModel
    {
        public string Email { get; set; }
        public string EmailError { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordError { get; set; }
        public string ConfirmPassword { get; set; }
        public string ConfirmPasswordError { get; set; }
    }
}
