using OpenQA.Selenium;


namespace ResetPassword_WHAT
{
public class ResetPassword : BasePage
{
    public ResetPassword(IWebDriver driver) : base(driver)
    {
    }

    public ResetPassword FillEmail(string email)
    {
        FillField(ResetPasswordLocator.emailAddressField, email);
        return this;
    }
    public ResetPassword FillNewPassword(string password)
    {
        FillField(ResetPasswordLocator.newPasswordField, password);
        return this;
    }
    public ResetPassword FillConfirmPassword(string password)
    {
        FillField(ResetPasswordLocator.confirmPasswordField, password);
        return this;
    }
    public ResetPassword ClickConfirmButton()
    {
        ClickItem(ResetPasswordLocator.confirmButton);
        return this;
    }
    public void ClickBackButton()
    {
        ClickItem(ResetPasswordLocator.backButton);
    }
}
}