//using OpenQA.Selenium;
////using ResetPassword.Locators;
//using What_PageObject;
//using What_Common.Resources;
//using What_PageObject;

//namespace ResetPassword
//{
//    public class ResetPasswordPage : BasePage
//    {
      
//        public ResetPasswordPage FillEmail(string email)
//        {
//            FillField(Locators.ResetPassword.emailAddressField, email);
//            return this;
//        }
//        public ResetPasswordPage FillNewPassword(string password)
//        {
//            FillField(Locators.ResetPassword.newPasswordField, password);
//            return this;
//        }
//        public ResetPasswordPage FillConfirmPassword(string password)
//        {
//            FillField(Locators.ResetPassword.confirmPasswordField, password);
//            return this;
//        }
//        public ResetPasswordPage ClickConfirmButton()
//        {
//            ClickElement(Locators.ResetPassword.confirmButton);
//            return this;
//        }
//        public void ClickBackButton()
//        {
//            ClickElement(Locators.ResetPassword.backButton);
//        }
//    }
//}