using OpenQA.Selenium;

namespace What_Common.Resources
{
    public class Locators
    {
        public static class ResetPassword
        {
            public static By emailAddressField = By.XPath("//input[@id='email']");
            public static By emailAddressError = By.XPath("//input[@id='email']/following-sibling::div[contains(@class,'text-danger')]");
            public static By newPasswordField = By.XPath("//input[@id='newPassword']");
            public static By newPasswordError = By.XPath("//input[@id='newPassword']/following-sibling::div[contains(@class,'text-danger')]");
            public static By confirmPasswordField = By.XPath("//input[@id='confirmNewPassword']");
            public static By confirmPasswordError = By.XPath("//input[@id='confirmNewPassword']/following-sibling::div[contains(@class,'text-danger')]");
            public static By confirmButton = By.XPath("//button[text()='Confirm']");
            public static By confirmButtonError = By.XPath("//button[text()='Confirm']/../following-sibling::div[contains(@class,'text-danger')]");
            public static By backButton = By.XPath("//button[text()='Back']");
            public static By xButton = By.XPath("//span[@aria-hidden='true']");
        }

    }
}
