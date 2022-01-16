//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using ResetPassword;

//namespace What_UITest;


//public class ResetPass
//{
//    IWebDriver driver;
//    [SetUp]
//    public void Setup()
//    {
//        driver = new ChromeDriver();
//        driver.Navigate().GoToUrl(@"http://localhost:8080/reset-password");
//    }

//    [Test]
//    public void Test1()
//    {
        
//        ResetPasswordPage resetPassword = new ResetPasswordPage();
//        resetPassword.FillEmail("test@test.com")
//            .FillNewPassword("qwerT123")
//            .FillConfirmPassword("qwerT123")
//            .ClickConfirmButton()
//            .ClickBackButton();
//        Assert.AreEqual("http://localhost:8080/auth", driver.Url);
//    }
//}