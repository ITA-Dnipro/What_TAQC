using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1.Secretaries
{
    class SecretariesPage
    {
        protected IWebDriver driver;
        public SecretariesPage(IWebDriver driver)
        {

        }
        public SecretariesPage ClickSecretariesPage()
        {
            driver.FindElement(new Locators().sidebarSecretary).Click();
            return new SecretariesPage(driver);
        }
        public SecretariesPage ClickNextPageOnPagination()
        {
            driver.FindElement(new Locators().paginationArrowRight).Click();
            return this;
        }
        public SecretariesPage ClickPreviousPageOnPagination()
        {
            driver.FindElement(new Locators().paginationArrowLeft).Click();
            return this;
        }
        public SecretariesPage SearchByName(string name)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElements(new Locators().elementsInTable));
            driver.FindElement(new Locators().searchField).SendKeys(name);
            return this;
        }
        public EditSecretary ClickEditButton()
        {
            driver.FindElement(new Locators().editButton).Click();
            return new EditSecretary(driver);
        }
        public SecretaryDetails ClickDetailsButton()
        {
            driver.FindElement(new Locators().detailsButtonTable).Click();
            return new SecretaryDetails(driver);
        }
        public AddSecretary ClickAddSecretaryButton()
        {
            driver.FindElement(new Locators().addButton).Click();
            return new AddSecretary(driver);
        }
    }
}
