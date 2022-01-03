using OpenQA.Selenium;

namespace ConsoleApp1.ForgotPassword
{
    class Locators
    {
        public By
            forgotPasswordLink = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[4]/div[1]/p/a"),
            emailField = By.XPath("//*[@id=\"email\"]"),
            sendButton = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[2]/button"),
            forgotPasswordInformation = By.XPath("/html/body/div[3]/div/div/div[2]"),
            backButton = By.XPath("/html/body/div[3]/div/div/div[3]/button"),
            crossButton = By.XPath("/html/body/div[3]/div/div/div[1]/button/span[1]"),
            accountDontExistLabel = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/p[2]"),
            invalidEmailLabel = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[1]/div");
    }
}


