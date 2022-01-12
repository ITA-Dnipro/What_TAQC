using ResetPassword.Locators;
using What_PageObject;

namespace ResetPassword
{
    public class ResetPasswordPage : BasePage
    {
        public ResetPasswordPage FillEmail(string email)
        {
            FillField(ResetPasswordLocator.emailAddressField, email);
            return this;
        }
        public ResetPasswordPage FillNewPassword(string password)
        {
            FillField(ResetPasswordLocator.newPasswordField, password);
            return this;
        }
        public ResetPasswordPage FillConfirmPassword(string password)
        {
            FillField(ResetPasswordLocator.confirmPasswordField, password);
            return this;
        }
        public ResetPasswordPage ClickConfirmButton()
        {
            ClickElement(ResetPasswordLocator.confirmButton);
            return this;
        }
        public void ClickBackButton()
        {
            ClickElement(ResetPasswordLocator.backButton);
        }
    }
}