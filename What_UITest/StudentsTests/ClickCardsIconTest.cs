using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_PageObject.SignInPage;
using What_PageObject.StudentsPage;


namespace What_UITest.StudentsTests
{
    internal class ClickCardsIconTest : BaseTest
    {
        BaseTest baseT = new BaseTest();
        private SignInPage signInPage;
        private StudentsPage studentPage;

        [SetUp]
        public void Setup()
        {
            baseT.Setup();
            signInPage = new SignInPage();
            studentPage = new StudentsPage();
            signInPage.LogIn("james.smith@example.com", "Nj_PJ7K9");
        }

        [Test]
        public void CardsIconTest()
        {
            studentPage.SidebarNavigateTo<StudentsPage>()
                .VerifyCardsSwitchButton();
        }

        [TearDown]
        public void TearDown()
        {
            baseT.AfterTest();
        }

    }
}
