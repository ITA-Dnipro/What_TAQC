using System;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.Secretaries
{
    public class SecretariesPage : BasePageWithSideBar
    {
        public SecretariesPage FillSearchField(string text)
        {
            FillField(Locators.SecretaryPage.searchField, text);
            return this;
        }
        public SecretariesPage ClickNextTopButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowRightInTop);
            return this;
        }
        public SecretariesPage ClickPrevTopButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowLeftInTop);
            return this;
        }
        public SecretariesPage ClickNextBottomButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowRightInTop);
            return this;
        }
        public SecretariesPage ClickPrevBottomButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowLeftInBottom);
            return this;
        }
        public SecretariesPage ClickSearchField()
        {
            ClickElement(Locators.SecretaryPage.searchField);
            return this;
        }
        public SecretariesPage ClickSortByName()
        {
            ClickElement(Locators.SecretaryPage.sortByName);
            return this;
        }
        public SecretariesPage ClickSortBySurname()
        {
            ClickElement(Locators.SecretaryPage.sortBySurname);
            return this;
        }
        public SecretariesPage ClickSortByRmail()
        {
            ClickElement(Locators.SecretaryPage.sortByEmail);
            return this;
        }
        public SecretariesPage ClickDisabledCheckbox()
        {
            ClickElement(Locators.SecretaryPage.disabledCheckbox);
            return this;
        }
        public List<string> GetTableData()
        {
            List<string> tableData = new List<string>();
            var table = Driver.Current.FindElements(Locators.SecretaryPage.tableData);
            foreach (var item in table)
            {
                tableData.Add(item.Text);
            }
            return tableData;
        }
        public List<string> GetCardsData()
        {
            List<string> cardsData = new List<string>();
            Regex regex = new Regex("(?<=(\\r\\n))(.*?)(?=(:))");
            var cards = Driver.Current.FindElements(Locators.SecretaryPage.cardData);
            foreach (var item in cards)
            {
                string cardName = regex.Replace(item.Text, "");
                string cardNameData = cardName.Replace(Environment.NewLine, "").Replace(":", "");
                cardsData.Add(cardNameData);
            }
            return cardsData;
        }
        public SecretariesPage CompareCardsDataWithTableData()
        {
            var tableData = GetTableData();
            Thread.Sleep(3000);
            ClickElement(Locators.SecretaryPage.cardsButton);
            Thread.Sleep(3000);
            var cardData = GetCardsData();
            Thread.Sleep(3000);
            CollectionAssert.AreEqual(tableData, cardData);
            return this;
        }
        public string GetNameFromTable(int number)
        {
            return Driver.Current.FindElement(Locators.SecretaryPage.CurrentTableNameData(number)).Text;
        }
        public SecretariesPage WaitTableData()
        {
            WaitUntilElementLoads<SecretariesPage>(Locators.SecretaryPage.tableData);
            return this;
        }
        public string GetRandomNameFromTable()
        {
            int number = new Random().Next(1, Driver.Current.FindElements(Locators.SecretaryPage.tableButton).Count + 1);
            return GetNameFromTable(number);
        }
        public SecretariesPage CompareSearchDatWithFirstDataFromTable()
        {
            string expected = GetRandomNameFromTable();
            FillSearchField(expected);
            Assert.AreEqual(expected, GetNameFromTable(1));
            return this;
        }
    }
}
