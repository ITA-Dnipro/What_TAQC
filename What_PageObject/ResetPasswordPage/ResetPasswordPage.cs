//using OpenQA.Selenium;
//using What_PageObject;
////using ResetPassword.Locators;


//namespace ResetPassword
//{
//    public class ResetPasswordPage : BasePage
//    {
//        public ResetPasswordPage(IWebDriver driver) : base(driver)
//        {
//        }

//        public ResetPasswordPage FillEmail(string email)
//        {
//            FillField(ResetPasswordLocator.emailAddressField, email);
//            return this;
//        }
//        public ResetPasswordPage FillNewPassword(string password)
//        {
//            FillField(ResetPasswordLocator.newPasswordField, password);
//            return this;
//        }
//        public ResetPasswordPage FillConfirmPassword(string password)
//        {
//            FillField(ResetPasswordLocator.confirmPasswordField, password);
//            return this;
//        }
//        public ResetPasswordPage ClickConfirmButton()
//        {
//            ClickItem(ResetPasswordLocator.confirmButton);
//            return this;
//        }
//        public void ClickBackButton()
//        {
//            ClickItem(ResetPasswordLocator.backButton);
//        }
//    }
//}