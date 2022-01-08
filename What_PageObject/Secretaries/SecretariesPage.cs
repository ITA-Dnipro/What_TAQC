using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace What_PageObject.Secretaries
{
    public class SecretariesPage
    {
        protected IWebDriver driver;
        public SecretariesPage(IWebDriver driver)
        {

        }
        public SecretariesPage ClickSecretariesPage()
        {
            driver.FindElement(Locators.sidebarSecretary).Click();
            return new SecretariesPage(driver);
        }
        public SecretariesPage ClickNextPageOnPagination()
        {
            driver.FindElement(Locators.paginationArrowRight).Click();
            return this;
        }
        public SecretariesPage ClickPreviousPageOnPagination()
        {
            driver.FindElement(Locators.paginationArrowLeft).Click();
            return this;
        }
        public SecretariesPage SearchByName(string name)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElements(Locators.elementsInTable));
            driver.FindElement(Locators.searchField).SendKeys(name);
            return this;
        }
        public EditSecretary ClickEditButton()
        {
            driver.FindElement(Locators.editButton).Click();
            return new EditSecretary(driver);
        }
        public SecretaryDetails ClickDetailsButton()
        {
            driver.FindElement(Locators.detailsButtonTable).Click();
            return new SecretaryDetails(driver);
        }
        public AddSecretary ClickAddSecretaryButton()
        {
            driver.FindElement(Locators.addButton).Click();
            return new AddSecretary(driver);
        }
    }
}
